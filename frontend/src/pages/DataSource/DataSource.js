import './DataSource.scss';

const DataSource = () => {
    return (
        <div className="data-source">
            <div>
                Źródła:
                <a href="https://ztp.krakow.pl/" target="_blank" rel="noreferrer">ZTP</a>
                <a href="https://zzm.krakow.pl/" target="_blank" rel="noreferrer">ZZM</a>
            </div>
            <div className='secret-section'>
                <a href="https://instytutdanychzdupy.edu.pl/" target="_blank" rel="noreferrer">IDzD</a>
            </div>
        </div>
    );
}

export default DataSource;