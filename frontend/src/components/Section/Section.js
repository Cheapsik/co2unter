import './Section.scss';


const Section = ({ name, description }) => (
    <div className="section-container">
      <p className="title">{name}</p>
      <p className="section-description">{description}</p>
    </div>
  );

  export default Section;