import './DataSource.scss';

const DataSource = () => {
    return (
        <div className="data-source">
            <div>
                Data Source:
                <a href="https://ztp.krakow.pl/" target="_blank">ZTP</a>
                <a href="https://zzm.krakow.pl/" target="_blank">ZZM</a>
            </div>
            <div className='special-section'>
                <a href="https://instytutdanychzdupy.edu.pl/" target="_blank">IDzD</a>
                <a href="https://www.facebook.com/IDzDPL/?locale=pl_PL" target="_blank">IDzDFb</a>
            </div>
        </div>
    );
}

export default DataSource;