import { useState } from 'react';
import './ServiceSector.scss';

const ServiceSector = () => {
  const [showDetails, setShowDetails] = useState(false);

  const toggleDetails = () => setShowDetails(!showDetails);

  return (
    <div className="service-container">
      <h1>Sektor Usługowy i Emisje  CO²</h1>

      <section className="description">
        <h2>Gastronomia a emisja  CO²</h2>
        <p>
          Gastronomia w znaczący sposób wpływa na wzrost emisji  CO². Częste wyjścia do restauracji, zwłaszcza te
          korzystające z jednorazowych opakowań, powodują znaczne zużycie energii oraz produkcję odpadów, co
          przyczynia się do emisji gazów cieplarnianych. Produkcja jednorazowych opakowań (kubki, talerze, sztućce),
          transport produktów spożywczych oraz energia zużywana w lokalach gastronomicznych (kuchnie, ogrzewanie,
          chłodzenie) znacząco zwiększają ślad węglowy. 
        </p>
        <button className="toggle-button" onClick={toggleDetails}>
          {showDetails ? 'Ukryj szczegóły' : 'Pokaż więcej'}
        </button>
        {showDetails && (
          <div className="details">
            <p>
              Każdy jednorazowy talerz, kubek czy sztućce to nie tylko odpad, który może rozkładać się setki lat,
              ale również energia i surowce potrzebne do jego produkcji. Na przykład, produkcja jednego
              plastikowego kubka to emisja ok. 0,08 kg  CO². W skali miesiąca, regularne korzystanie z jednorazowych
              opakowań może prowadzić do znaczącego wzrostu emisji, zwłaszcza w dużych miastach jak Kraków.
            </p>
            <p>
              Zastanów się, jak często korzystasz z jednorazowych opakowań oraz jaką ilość energii zużywają
              restauracje, które odwiedzasz. Czy wiesz, że lokalna zieleń miejska mogłaby zneutralizować część
              tych emisji? Drzewa w miastach pochłaniają  CO², wspomagając walkę ze zmianami klimatycznymi, ale
              ich zdolności są ograniczone w stosunku do rosnącej ilości emisji.
            </p>
          </div>
        )}
      </section>
    </div>
  );
};

export default ServiceSector;
