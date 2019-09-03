handlers.logoutUser = function (contex){
    userService.logout().then(() => {
        sessionStorage.clear();
        notifications.showSuccess('User logged out successfully');
        contex.redirect('#/home');
      }).catch(function (err) {
        notifications.showError(err.responseJSON.description);
      });
}