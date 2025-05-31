function setTheme(theme) {
    if (theme === 'dark') {
        document.documentElement.setAttribute('data-bs-theme', 'dark');
    } else {
        document.documentElement.setAttribute('data-bs-theme', 'light');
    }
}

const prefersDarkScheme = window.matchMedia('(prefers-color-scheme: dark)');
// Set initial theme
setTheme(prefersDarkScheme.matches ? 'dark' : 'light');

// Listen for changes
prefersDarkScheme.addEventListener('change', (event) => {
    setTheme(event.matches ? 'dark' : 'light');
});
