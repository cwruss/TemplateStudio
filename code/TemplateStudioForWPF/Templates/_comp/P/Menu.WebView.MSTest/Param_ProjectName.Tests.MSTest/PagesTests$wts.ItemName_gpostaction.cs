﻿namespace Param_RootNamespace.Tests.MSTest
{
    [TestClass]
    public class PagesTests
    {
        public PagesTests()
        {
            // App Services
//{[{
            _container.RegisterType<IRightPaneService, RightPaneService>();
//}]}
        }
//^^
//{[{
        // TODO: Add tests for functionality you add to wts.ItemNameViewModel.
        [TestMethod]
        public void Testwts.ItemNameViewModelCreation()
        {
            var vm = _container.Resolve<wts.ItemNameViewModel>();
            Assert.IsNotNull(vm);
        }
//}]}
    }
}