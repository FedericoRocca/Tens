using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MenuTesting
{
    // A Test behaves as an ordinary method
    [Test]
    public void MenuTestingSimplePasses()
    {
        // Use the Assert class to test conditions
        Menu menu = new Menu();
        Assert.DoesNotThrow(menu.quit, "Menu.Quit exception");
    }

    [Test]
    public void MonedaMenuTesting()
    {
        MonedaMenu monMenu = new MonedaMenu();
        Assert.AreNotEqual(0, monMenu.rotationSpeed, "La velocidad de rotación no debería ser 0");
    }
    
    [Test]
    public void SalirMenuInGameTesting()
    {
        MenuInGame menu = new MenuInGame();
        Assert.DoesNotThrow(menu.quit, "MenuInGame.Quit exception");
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator MenuTestingWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
