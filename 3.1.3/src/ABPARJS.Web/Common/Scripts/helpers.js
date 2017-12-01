var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('ABPARJS');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);