<template>
  <div class="line-chart-container">
    <h2>{{ deviceName }}</h2>
    <canvas ref="lineChartCanvas"></canvas>
  </div>
</template>

<script>
import { ref, onMounted, watch } from 'vue';
import { Chart, registerables } from 'chart.js';

// Register Chart.js plugins
Chart.register(...registerables);

export default {
  props: {
    temperatureData: Array, // Temperature data from App.vue
    deviceName: String, // Name of the selected device
  },
  setup(props) {
    const lineChartCanvas = ref(null);
    let chart = null; // Define chart variable

    onMounted(() => {
      const ctx = lineChartCanvas.value;

      chart = new Chart(ctx, {
        type: 'line',
        data: {
          labels: generateTimeLabels(), // Generate time labels
          datasets: [
            {
              label: 'Temperature',
              data: props.temperatureData, // Use the temperatureData prop
              borderColor: 'rgb(255, 99, 132)',
              borderWidth: 2,
              fill: false,
            },
          ],
        },
        options: {
          responsive: true,
          maintainAspectRatio: false,
          scales: {
            x: {
              title: {
                display: true,
                text: 'Time',
              },
            },
            y: {
              title: {
                display: true,
                text: 'Temperature (°C)',
              },
            },
          },
        },
      });
    });

    // Watch for changes in temperatureData prop
    watch(() => props.temperatureData, (newData) => {
      // Check if chart is defined before updating
      if (chart) {
        chart.data.datasets[0].data = newData;
        chart.update();
      }
    });

    function generateTimeLabels() {
      const labels = [];
      const now = new Date();

      for (let i = 0; i < 5; i++) {
        const time = new Date(now - i * 3600 * 1000); // Subtract hours
        const hours = time.getHours().toString().padStart(2, '0');
        const minutes = time.getMinutes().toString().padStart(2, '0');
        labels.unshift(`${hours}:${minutes}`);
      }

      return labels;
    }

    return {
      lineChartCanvas,
    };
  },
};
</script>
