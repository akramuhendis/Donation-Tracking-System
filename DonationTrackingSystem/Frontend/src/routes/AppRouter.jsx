import { Routes, Route } from 'react-router-dom'
import ProtectedRoute from './ProtectedRoute'
import LoginPage from '../auth/LoginPage'
import RegisterPage from '../auth/RegisterPage'
import Dashboard from '../pages/Dashboard'
import BagislarPage from '../pages/Bagislar'
import MuhasebePage from '../pages/Muhasebe'
import RaporlamaPage from '../pages/Raporlama'
import ExportPage from '../pages/Export'
import AyarlarPage from '../pages/Ayarlar'

const AppRouter = () => {
  return (
    <Routes>
      <Route path="/login" element={<LoginPage />} />
      <Route path="/register" element={<RegisterPage />} />
      
      <Route element={<ProtectedRoute />}>
        <Route path="/" element={<Dashboard />} />
        <Route path="/bagislar" element={<BagislarPage />} />
        <Route path="/muhasebe" element={<MuhasebePage />} />
        <Route path="/raporlama" element={<RaporlamaPage />} />
        <Route path="/export" element={<ExportPage />} />
        <Route path="/ayarlar" element={<AyarlarPage />} />
      </Route>
    </Routes>
  )
}

export default AppRouter