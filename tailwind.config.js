/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
      "./Pages/**/*.{cshtml,html,js}",
      "./wwwroot/**/*.{html,js}",
      "./**/*.{cshtml,html,js}"
    ],
    theme: {
      extend: {
        colors: {
          'white-fill': '#F0FFF9',
          'lighter-shade': '#6CA9BA',
          'mid-color': '#77F77F',
          'darker-shade': '#337D58',
        },
        fontFamily: {
          'poppins': ['Poppins', 'sans-serif'],
          'geologica': ['Geologica', 'sans-serif'],
        },
      },
    },
    plugins: [],
  }