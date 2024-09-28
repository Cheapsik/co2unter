import React from 'react';
import './main.scss';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Nav from './components/Nav';
import Home from './pages/Home';
import EmissionCalculator from './pages/EmissionCalculator';

const Co2Hunter = () => {
  const sections = [
    { title: 'Indywidualne działania mieszkańców', component: <EmissionCalculator />},
    { title: 'Transport', component: <p>A</p>},
    { title: 'Sektor usługowy', component: <p>B</p>},
    { title: 'Wydarzenia', component: <p>C</p>},
  ]

  const getUrl = (title) => {
    const name = title.toLowerCase().replace(/ /g, '-')
    return `/${name}`;
  }

  return (
    <div className="App">
      <Router>
            <Nav />

            <Routes>
              <Route path="/" element={<Home />} />
                {sections.map((section, idx) => (
                  <Route
                    key={idx}
                    path={`/${getUrl(section.title)}`}
                    element={section.component}
                  />
                ))}
            </Routes>
        </Router>
    </div>
  );
}

export default Co2Hunter;
