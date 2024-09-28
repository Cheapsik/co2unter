import React from 'react';
import './main.scss';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import Section from './components/Section/Section'
import Nav from './components/Nav';

const Co2Hunter = () => {
  const sections = [
    { title: 'Indywidualne działania mieszkańców', description: 'Indywidualne działania mieszkańców Indywidualne działania mieszkańców Indywidualne działania mieszkańców'},
    { title: 'Transport', description: 'Transport Transport Transport'},
    { title: 'Sektor usługowy', description: 'Sektor usługowy Sektor usługowy Sektor usługowy'},
    { title: 'Wydarzenia', description: 'Wydarzenia Wydarzenia Wydarzenia'},
  ]

  return (
    <div className="App">
      <Nav />
      <Router>
          <div className="container">
            {sections.map((section, idx) => (
              <Link key={idx} to={`/${section.title}`} className="square">
                {section.title}
              </Link>
            ))}
          </div>
          <Routes>
            {sections.map((section, idx) => (
              <Route
                key={idx}
                path={`/${section}`}
                element={<Section name={section.title} description={section.description}/>}
              />
            ))}
          </Routes>
        </Router>
    </div>
  );
}

export default Co2Hunter;
