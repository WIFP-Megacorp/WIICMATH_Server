<template>
  <div class="dashboard">
    <div class="iot-container">
      <h1>IoT Device Dashboard</h1>
      <div class="boxes-container">
        <div class="iot-boxes">
          <div class="iot-box" v-for="(device, index) in devices" :key="index">
            <IoTDevice
              :deviceName="device.deviceName"
              :currentTemperature="device.currentTemperature"
              :currentHumidity="device.currentHumidity"
              @select-device="handleDeviceSelect"
            />
          </div>
        </div>
        <button class="scan-button">Add Devices</button>
      </div>
    </div>
    <div class="history-container">
      <div class="history-box">
        <TemperatureHistory
          v-if="selectedDeviceName && selectedDeviceTemperatureData"
          :temperatureData="selectedDeviceTemperatureData"
          :deviceName="selectedDeviceName"
        />
        <h1 v-else>Select a device to display temperature and humidity history.</h1>
      </div>
      <div class="history-box">
        <HumidityHistory
          v-if="selectedDeviceName && selectedDeviceHumidityData"
          :humidityData="selectedDeviceHumidityData"
          :deviceName="selectedDeviceName"
        />
      </div>
    </div>
  </div>
</template>

<script>
import IoTDevice from "@/components/IoTDevice.vue"; // Adjust the import path as needed
import TemperatureHistory from "@/components/TemperatureHistory.vue"; // Adjust the import path as needed
import HumidityHistory from "@/components/HumidityHistory.vue"; // Adjust the import path as needed

export default {
  data() {
    return {
      devices: [
        {
          deviceName: "Device 1",
          temperature: [25.5, 25.6, 25.4, 25.8, 25.7],
          humidity: [55, 56, 54, 58, 57],
          currentTemperature: 25.7,
          currentHumidity: 57,
        },
        {
          deviceName: "Device 2",
          temperature: [22.8, 22.9, 23.1, 22.7, 22.5],
          humidity: [60, 61, 59, 62, 58],
          currentTemperature: 22.5,
          currentHumidity: 58,
        },
        {
          deviceName: "Device 3",
          temperature: [24.1, 24.2, 24.3, 24.0, 24.5],
          humidity: [58, 59, 57, 60, 61],
          currentTemperature: 24.5,
          currentHumidity: 61,
        },
        // Add more devices as needed
      ],
      selectedDeviceName: "", // Store the selected device name
    };
  },
  computed: {
    selectedDeviceTemperatureData() {
      return this.getSelectedDevice()?.temperature || [];
    },
    selectedDeviceHumidityData() {
      return this.getSelectedDevice()?.humidity || [];
    },
  },
  methods: {
    handleDeviceSelect(selectedDevice) {
      // Handle the device selection here
      console.log(`Selected device: ${selectedDevice}`);
      this.selectedDeviceName = selectedDevice;
    },
    getSelectedDevice() {
      return this.devices.find((device) => device.deviceName === this.selectedDeviceName);
    },
  },
  components: {
    IoTDevice,
    TemperatureHistory,
    HumidityHistory,
  },
};
</script>