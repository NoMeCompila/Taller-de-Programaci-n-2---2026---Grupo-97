using MobileSolutions.BusinessLayer.Models;

namespace MobileSolutions.BusinessLayer
{
    /// <summary>
    /// Estado de la sesión activa (singleton estático).
    /// </summary>
    public static class SesionActual
    {
        public static int UserId { get; private set; }
        public static int ProfileId { get; private set; }
        public static string ProfileName { get; private set; } = string.Empty;
        public static string Username { get; private set; } = string.Empty;
        public static string Name { get; private set; } = string.Empty;

        public static bool IsAuthenticated => UserId > 0;

        /// <summary>
        /// Puebla la sesión con el usuario autenticado.
        /// Lo invoca LoginForm tras validar credenciales.
        /// </summary>
        public static void IniciarSesion(User user)
        {
            UserId = user.UserId;
            ProfileId = user.ProfileId;
            ProfileName = user.ProfileName;
            Username = user.Username;
            Name = user.Name;
        }

        /// <summary>
        /// Restablece la sesión a sus valores por defecto (0 / string.Empty).
        /// Debe invocarse al cerrar sesión.
        /// </summary>
        public static void LimpiarSesion()
        {
            UserId = 0;
            ProfileId = 0;
            ProfileName = string.Empty;
            Username = string.Empty;
            Name = string.Empty;
        }
    }
}