document.addEventListener('DOMContentLoaded', function() {
  fetch('https://api.open-meteo.com/v1/forecast?latitude=28.6139&longitude=77.209&hourly=temperature_2m')
    .then(response => response.json())
    .then(data => {
      const weatherContainer = document.getElementById('weather-container');
      if (!weatherContainer) return;
      const temps = data.hourly.temperature_2m.slice(0, 6); // Show next 6 hours
      const times = data.hourly.time.slice(0, 6);
      let html =`
        <img src="/Images/cloudy-day-1.svg"  width="60" height="60" alt="Weather Icon" style="filter: invert(1);"/>
        <h5 style="color:white;">New Delhi Hourly Temperature</h5>
        <ul style="color:white;">
      `;      
      for (let i = 0; i < temps.length; i++) {
        html += `<li>${times[i]}: ${temps[i]}°C</li>`;
      }
      html += '</ul>';
      weatherContainer.innerHTML = html;
    })
    .catch(error => {
      const weatherContainer = document.getElementById('weather-container');
      if (weatherContainer) {
        weatherContainer.innerHTML = '<p class="text-danger">Weather data could not be loaded.</p>';
      }
      console.error('Weather API Error:', error);
    });
   
});

document.addEventListener("DOMContentLoaded", function () {
    // Replace with your NewsAPI key
    const apiKey = "YOUR_NEWSAPI_KEY";
    const url = `https://newsdata.io/api/1/latest?apikey=&q=WORLD%20NEWS%20`;

    fetch(url)
        .then(response => response.json())
        .then(data => {
            const newsDiv = document.getElementById("live-news");
            if (data.articles && data.articles.length > 0) {
                let html = "<h4>Latest Headlines</h4><ul>";
                data.articles.forEach(article => {
                    html += `<li><a href="${article.url}" target="_blank">${article.title}</a></li>`;
                });
                html += "</ul>";
                newsDiv.innerHTML = html;
            } else {
                newsDiv.innerHTML = "<h4>Latest Headlines</h4><p>No news found.</p>";
            }
        })
        .catch(error => {
            document.getElementById("live-news").innerHTML = "<h4>Latest Headlines</h4><p>Unable to load news.</p>";
        });
});
 

