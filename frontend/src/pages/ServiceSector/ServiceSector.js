import { useState, useEffect } from 'react';
import './ServiceSector.scss';

const ServiceSector = () => {
  const [showDetails, setShowDetails] = useState(false);
  const [serviceEmissionData, setServiceEmissionData] = useState([]);
  
  useEffect(() => {
    const fetchData = async () => {
      const response = await fetch(`${process.env.REACT_APP_API_URL ?? 'https://krakco2.pl/api/'}emissions/service`);
      const data = await response.json();
      setServiceEmissionData(data);
    };
    
    fetchData();
  }, []);
  
  const toggleDetails = () => setShowDetails(!showDetails);

  const renderCO2Emissions = (groupedEmissions) => {
    const serviceTypeMap = {
      gastronomy: 'Gastronomia',
      hospitality: 'Hospitalizacja',
      trade: 'Handel',
      'health services': 'Usługi zdrowotne',
      'public transport': 'Transport publiczny',
    };

    return (
      <>
        {Object.keys(groupedEmissions).map((serviceType) => {
          const translatedServiceType = serviceTypeMap[serviceType] || serviceType;

          return (
            <div key={serviceType} className="service-emission">
              <h3 className="service-title">{translatedServiceType}</h3>
              <ul className="service-list">
                {groupedEmissions[serviceType].map(({ year, totalCO2EmissionsKg }) => (
                  <li key={year} className="service-item">
                    <span className="year">Rok {year}: </span>
                    <span className="emission">{totalCO2EmissionsKg} kg CO₂</span>
                  </li>
                ))}
              </ul>
            </div>
          );
        })}
      </>
    );
  };

  const groupedEmissions = serviceEmissionData.reduce((acc, item) => {
    const { serviceType, totalCO2EmissionsKg, year } = item;
    if (!acc[serviceType]) acc[serviceType] = [];
    acc[serviceType].push({ year, totalCO2EmissionsKg });
    return acc;
  }, {});

  return (
    <div className="service-container">
      <h1>Sektor Usługowy i Emisje CO₂</h1>

      <section className="description">
        <h2>Emisje CO₂ w sektorze usługowym</h2>
        <p>
          Sektor usługowy w znaczący sposób przyczynia się do globalnej emisji CO₂. W szczególności
          sektory takie jak gastronomia, handel i hospitalizacja generują znaczne ilości gazów cieplarnianych
          ze względu na zużycie energii, transport i wytwarzanie odpadów.
        </p>
        <button className="toggle-button" onClick={toggleDetails}>
          {showDetails ? 'Ukryj szczegóły' : 'Pokaż więcej'}
        </button>
        {showDetails && (
          <div className="details">
            <p>
              Na przykład, sektor gastronomiczny w 2024 roku wygenerował około 16,000 kg CO₂. Emisje te pochodzą głównie z transportu
              produktów spożywczych, zużycia energii przez restauracje oraz wytwarzania jednorazowych opakowań. 
            </p>
            <p>
              W sektorze hospitalizacji, szpitale i placówki zdrowotne zużywają znaczne ilości energii na operacje medyczne,
              ogrzewanie i chłodzenie, co w 2024 roku przełożyło się na emisję 11,000 kg CO₂. Zrównoważona modernizacja
              systemów energetycznych oraz ograniczenie zużycia jednorazowych materiałów mogłoby zmniejszyć emisję w tym sektorze.
            </p>
            <p>
              W handlu, emisje są generowane głównie przez transport produktów do sklepów, zużycie energii w lokalach handlowych
              oraz wytwarzanie odpadów. W 2024 roku emisje związane z handlem wyniosły około 8,500 kg CO₂.
            </p>
            <p>
              Średnio w sektorze usługowym każdy kilogram zużytej energii generuje około 0.4 kg CO₂, a wykorzystanie
              zrównoważonych źródeł energii może znacząco obniżyć te wartości.
            </p>
          </div>
        )}
      </section>
      <section className="description">
        <h2>Emisje CO₂ w różnych usługach</h2>
          {renderCO2Emissions(groupedEmissions)}
        </section>
    </div>
  );
};

export default ServiceSector;
