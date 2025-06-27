import { Link } from 'react-router-dom'

const Sidebar = () => {
  const menuItems = [
    { path: '/', label: 'Dashboard' },
    { path: '/bagislar', label: 'Bağışlar' },
    { path: '/muhasebe', label: 'Muhasebe' },
    { path: '/raporlama', label: 'Raporlama' },
    { path: '/export', label: 'Dışa Aktar' },
    { path: '/ayarlar', label: 'Ayarlar' }
  ]

  return (
    <div className="bg-gray-800 text-white w-64 space-y-6 py-7 px-2 fixed inset-y-0 left-0">
      <nav>
        {menuItems.map((item) => (
          <Link
            key={item.path}
            to={item.path}
            className="block py-2.5 px-4 rounded transition duration-200 hover:bg-gray-700"
          >
            {item.label}
          </Link>
        ))}
      </nav>
    </div>
  )
}

export default Sidebar