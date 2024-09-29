import './Nav.scss';
import { useNavigate, useLocation } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faHouseChimney } from '@fortawesome/free-solid-svg-icons';


const Nav = () => {
  const navigate = useNavigate();
  const location = useLocation();
  const shouldDisplay = location.pathname !== '/';

  return (
    <>
      {shouldDisplay && 
        <nav>
          <button className="home-button" onClick={() => navigate('/')}>
            <FontAwesomeIcon icon={faHouseChimney} />
          </button>
        </nav>
        }
    </>
  );
}

  export default Nav;