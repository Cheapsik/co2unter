import './EmissionList.scss'


const EmissionList = ({ taskList }) => {
    
      const toggleDetails = (task) => {
        console.log(task)
        task.detailsVisible = !task.detailsVisible;
      };

    return (
        <ul className="task-list">
            {taskList.map((task) => (
            <li key={task.id} className="task-item">
                <div className="task-summary">
                <span>{`${task.name} - ${task.distance} km`}</span>
                <div>
                    <button onClick={() => toggleDetails(task)} className="toggle-button">
                        {task.detailsVisible ? 'Ukryj szczegóły' : 'Pokaż więcej'}
                    </button>
                    {/* <button onClick={() => removeTask(task.id)} className="remove-button">Usuń</button> */}
                </div>
                </div>
                {task.detailsVisible}
                {task.detailsVisible && (
                <div className="task-details">
                    <p>Emisje CO2 z transportu: {task.emissions.transportEmissions} kg</p>
                    <p>Emisje CO2 z diety: {task.emissions.dietEmissions} kg</p>
                    <p>Emisje CO2 z zużycia wody: {task.emissions.waterEmissions} kg</p>
                    <p>Emisje CO2 z odpadów: {task.emissions.wasteEmissions} kg</p>
                    <p><strong>Łączne emisje CO2: {task.emissions.totalEmissions} kg</strong></p>
                </div>
                )}
            </li>
            ))}
        </ul>
    )
}

export default EmissionList;