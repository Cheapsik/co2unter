import { useState, useEffect } from 'react';
import './TransportSector.scss';

const TransportSector = () => {
  const [transportData, setTransportData] = useState([]);
  const [showDetails, setShowDetails] = useState(false);

  useEffect(() => {
    const fetchData = async () => {
      const response = await fetch('https://co2unter.redtm.pl/api/TransportEmissions');
      const data = await response.json();
      setTransportData(data);
    };
    
    fetchData();
  }, []);

  const toggleDetails = () => setShowDetails(!showDetails);

  const calculateAverageEmissions = (transportType) => {
    const filteredData = transportData.filter(item => item.transportType === transportType);
    const totalEmissions = filteredData.reduce((sum, item) => sum + item.totalCO2EmissionsKg, 0);
    return (totalEmissions / filteredData.length).toFixed(2);
  };

  return (
    <div className="container">
      <h1>Transport i Emisje CO2</h1>

      <section className="description">
        <h2>Różne środki transportu a emisja CO2</h2>
        <p>
          Różne środki transportu generują różne poziomy emisji CO2. Korzystanie z komunikacji miejskiej,
          ruch samochodowy, rowerowy oraz pieszy mają swoje unikalne ślady węglowe. Warto zrozumieć, jak nasze
          codzienne wybory transportowe wpływają na środowisko oraz jakie są różnice w emisji pomiędzy
          poszczególnymi środkami transportu.
        </p>
        <button className="toggle-button" onClick={toggleDetails}>
          {showDetails ? 'Ukryj szczegóły' : 'Pokaż więcej'}
        </button>
        {showDetails && (
          <div className="details">
            <h3>Średnie emisje CO2 według środka transportu:</h3>
            <ul>
              <li>Samochód: {calculateAverageEmissions('car')} kg CO2</li>
              <li>Transport publiczny: {calculateAverageEmissions('public transport')} kg CO2</li>
              <li>Rower: {calculateAverageEmissions('bike')} kg CO2</li>
              <li>Pieszo: {calculateAverageEmissions('walking')} kg CO2</li>
            </ul>
            <p>
              Na przykład, w 2024 roku transport samochodowy wygenerował 250 kg CO2 przy całkowitym
              dystansie 1500 km. Z kolei transport publiczny w tym samym roku wyemitował jedynie 75 kg
              CO2 na dystansie 1200 km. Warto zauważyć, że jazda na rowerze i chodzenie nie generują
              żadnych emisji CO2, co czyni je najlepszymi wyborami ekologicznymi.
            </p>
            <p>
              Ruch rowerowy oraz pieszy są najlepszymi opcjami dla środowiska, ponieważ
              nie generują emisji CO2. Zachęcanie do korzystania z tych form transportu
              może znacząco przyczynić się do zmniejszenia emisji gazów cieplarnianych w miastach.
              Co więcej, każda podróż poza miejscem zamieszkania, czy to w celu turystycznym, czy
              zawodowym, wiąże się z dodatkowymi emisjami, które również warto brać pod uwagę
              przy planowaniu.
            </p>
          </div>
        )}
      </section>

      <section className="other-sectors">
        <h2>Podsumowanie</h2>
        <p>
          Wybór środka transportu ma kluczowe znaczenie dla ochrony środowiska. Zmiana nawyków
          transportowych, takich jak korzystanie z komunikacji miejskiej lub roweru, może
          znacząco zmniejszyć emisje CO2. Świadomość wpływu transportu na środowisko
          jest pierwszym krokiem do podejmowania bardziej zrównoważonych decyzji.
        </p>
      </section>
    </div>
  );
};

export default TransportSector;