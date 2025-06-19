/* Reset and base styles */
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  font-family: 'Georgia', serif;
  background-color: #fff4f8;
  color: #4c2a36;
  line-height: 1.6;
}

/* Global links */
a {
  text-decoration: none;
  color: #d66a92;
  transition: color 0.3s ease;
}

a:hover {
  color: #b94c7b;
}

.container {
  width: 90%;
  max-width: 1200px;
  margin: auto;
}

/* Header */
header {
  background-color: #fff;
  padding: 20px 0;
  box-shadow: 0 2px 10px rgba(0, 0, 0, 0.05);
  position: sticky;
  top: 0;
  z-index: 1000;
}

.logo {
  font-size: 2rem;
  font-weight: bold;
  color: #d66a92;
}

header .container {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

nav {
  display: flex;
  gap: 20px;
}

/* Hero section */
.hero {
  background: url('images/hero.jpg') center/cover no-repeat;
  height: 90vh;
  display: flex;
  align-items: center;
  justify-content: center;
  text-align: center;
}

.hero-content {
  background-color: rgba(255, 255, 255, 0.85);
  padding: 40px;
  border-radius: 12px;
  max-width: 600px;
}

.hero h2 {
  font-size: 2.5rem;
  color: #d34c85;
  margin-bottom: 10px;
}

.hero p {
  font-size: 1.2rem;
  margin-bottom: 20px;
}

.btn {
  background-color: #f7c1d9;
  color: #4c2a36;
  padding: 10px 25px;
  border-radius: 30px;
  font-weight: bold;
  border: none;
  cursor: pointer;
  transition: 0.3s;
}

.btn:hover {
  background-color: #ecaac9;
}

/* Sections */
.featured,
.shop {
  padding: 60px 20px;
  background-color: #fff;
}

.featured h2,
.shop h2,
.about h2,
.contact h2 {
  text-align: center;
  font-size: 2.2rem;
  color: #d66a92;
  margin-bottom: 30px;
}

/* Product grid */
.grid {
  display: grid;
  gap: 30px;
  grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
  padding: 0 20px;
}

/* Cards */
.card {
  background-color: #fff;
  padding: 20px;
  border-radius: 15px;
  text-align: center;
  border: 1px solid #f5cbdc;
  box-shadow: 0 2px 10px rgba(0, 0, 0, 0.05);
  transition: transform 0.3s ease;
}

.card:hover {
  transform: scale(1.03);
}

.card img {
  width: 100%;
  height: 300px;
  object-fit: cover;
  border-radius: 10px;
  margin-bottom: 15px;
}

.card h3 {
  font-size: 1.3rem;
  color: #b64c7a;
  margin-bottom: 5px;
}

.card p {
  color: #4c2a36;
  font-weight: bold;
}

/* About & Contact */
.about, .contact {
  background-color: #fff8fb;
  padding: 60px 20px;
}

.about p {
  max-width: 700px;
  margin: 0 auto;
  font-size: 1.1rem;
  text-align: center;
}

/* Contact form */
form {
  max-width: 600px;
  margin: 0 auto;
  display: flex;
  flex-direction: column;
  gap: 15px;
}

input,
textarea {
  padding: 12px;
  border: 1px solid #e8aac1;
  border-radius: 10px;
  font-size: 1rem;
  font-family: inherit;
  background-color: #fff;
  resize: none;
}

/* Button inside form */
button.btn {
  width: fit-content;
  align-self: center;
}

/* Footer */
footer {
  text-align: center;
  background-color: #ffeaf3;
  padding: 20px;
  font-size: 0.9rem;
  color: #7b4b58;
}

/* Responsive */
@media (max-width: 768px) {
  header .container {
    flex-direction: column;
    gap: 10px;
  }

  nav {
    flex-direction: column;
    align-items: center;
  }

  .hero h2 {
    font-size: 2rem;
  }

  .hero-content {
    padding: 20px;
  }

  .btn {
    padding: 8px 20px;
  }
}

