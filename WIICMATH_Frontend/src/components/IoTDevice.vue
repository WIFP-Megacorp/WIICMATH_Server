<template>
  <div class="iot-device">
    <button class="iot-button" @click="selectDevice">
      <h3>{{ deviceName }}</h3>
      <h4>{{ currentTemperature }}°C </h4>
      <h4>{{ currentHumidity }}% </h4>
   </button>
  </div>
</template>
  
<script>
export default {
  props: {
    deviceName: String,
    currentTemperature: Number, // Add this prop
    currentHumidity: Number, // Add this prop
  },
  methods: {
    selectDevice() {
      this.$emit("select-device", this.deviceName);
    },
  },
};
</script>