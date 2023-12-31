FROM mcr.microsoft.com/mssql/server:2019-latest

# Elevate to root to install required packages
USER root

RUN apt-get update \
    && apt-get install unzip libunwind8 libicu66 libssl-dev -y


# Install SQLPackage for Linux and make it executable
RUN wget -progress=bar:force -q -O sqlpackage.zip https://aka.ms/sqlpackage-linux \
    && unzip -qq sqlpackage.zip -d /opt/sqlpackage \
    && chmod +x /opt/sqlpackage/sqlpackage \
    && chown -R mssql /opt/sqlpackage \
    && mkdir /tmp/db \
    && chown -R mssql /tmp/db

# Configure external build arguments to allow configurability.
ARG DBNAME=WIICHMATH_DB
ARG DACPAC_path=./WIICMATH_DB.dacpac

# Configure the required environmental variables
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=Pass!234
ENV DACPAC_PATH=$DACPAC_path

# Add the DACPAC to the image
COPY $DACPAC_PATH /tmp/db/WIICMATH_DB.dacpac


# Launch SQL Server, confirm startup is complete, deploy the DACPAC, then terminate SQL Server.
# See https://stackoverflow.com/a/51589787/488695
RUN ( /opt/mssql/bin/sqlservr & ) | grep -q "Service Broker manager has started" \
    && /opt/sqlpackage/sqlpackage /a:Publish /tsn:localhost /tdn:${DBNAME} /tu:sa /tp:$SA_PASSWORD /sf:/tmp/db/WIICMATH_DB.dacpac /stsc:True /ttsc:true \
    && rm -r /tmp/db \
    && pkill sqlservr \
    && rm -r /opt/sqlpackage