<template>
    <div class="line-chart-container">
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
      humidityData: Array, // Humidity data from App.vue
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
                label: 'Humidity',
                data: props.humidityData, // Use the humidityData prop
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
                  text: 'Humidity (%)',
                },
              },
            },
          },
        });
      });
  
      // Watch for changes in humidityData prop
      watch(() => props.humidityData, (newData) => {
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
  