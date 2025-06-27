import { useAuth } from '../auth/useAuth'

const Navbar = () => {
  const { user, logout } = useAuth()

  return (
    <nav className="bg-white shadow-lg">
      <div className="max-w-7xl mx-auto px-4">
        <div className="flex justify-between h-16">
          <div className="flex items-center">
            <h1 className="text-xl font-bold">Bağış Takip Sistemi</h1>
          </div>
          
          <div className="flex items-center">
            <span className="mr-4">{user?.email}</span>
            <button
              onClick={logout}
              className="bg-red-500 text-white px-4 py-2 rounded"
            >
              Çıkış
            </button>
          </div>
        </div>
      </div>
    </nav>
  )
}

export default Navbar