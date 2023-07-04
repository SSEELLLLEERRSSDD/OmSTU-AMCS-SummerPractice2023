﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace spacebattletests
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class Перемещение_ШатлаFeature : object, Xunit.IClassFixture<Перемещение_ШатлаFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Calculator.feature"
#line hidden
        
        public Перемещение_ШатлаFeature(Перемещение_ШатлаFeature.FixtureData fixtureData, spacebattletests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("ru"), "", "Перемещение_шатла", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Игровой объект может перемещаться по прямой")]
        [Xunit.TraitAttribute("FeatureTitle", "Перемещение_шатла")]
        [Xunit.TraitAttribute("Description", "Игровой объект может перемещаться по прямой")]
        public void ИгровойОбъектМожетПеремещатьсяПоПрямой()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Игровой объект может перемещаться по прямой", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
testRunner.Given("космический корабль находится в точке пространства с координатами (12, 5)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 6
testRunner.And("имеет мгновенную скорость (-5, 3)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 7
testRunner.When("происходит прямолинейное равномерное движение без деформации", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 8
testRunner.Then("космический корабль перемещается в точку пространства с координатами (7, 8)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Если невозможно определить текущее положение игрового объекта в пространстве, то " +
            "перемещение по прямой невозможно")]
        [Xunit.TraitAttribute("FeatureTitle", "Перемещение_шатла")]
        [Xunit.TraitAttribute("Description", "Если невозможно определить текущее положение игрового объекта в пространстве, то " +
            "перемещение по прямой невозможно")]
        public void ЕслиНевозможноОпределитьТекущееПоложениеИгровогоОбъектаВПространствеТоПеремещениеПоПрямойНевозможно()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Если невозможно определить текущее положение игрового объекта в пространстве, то " +
                    "перемещение по прямой невозможно", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 12
testRunner.Given("космический корабль, положение в пространстве которого невозможно определить", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 13
testRunner.And("имеет мгновенную скорость (-5, 3)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 14
testRunner.When("происходит прямолинейное равномерное движение без деформации", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 15
testRunner.Then("возникает ошибка Exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Если невозможно определить мгновенную скорость игрового объекта, то перемещение п" +
            "о прямой невозможно")]
        [Xunit.TraitAttribute("FeatureTitle", "Перемещение_шатла")]
        [Xunit.TraitAttribute("Description", "Если невозможно определить мгновенную скорость игрового объекта, то перемещение п" +
            "о прямой невозможно")]
        public void ЕслиНевозможноОпределитьМгновеннуюСкоростьИгровогоОбъектаТоПеремещениеПоПрямойНевозможно()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Если невозможно определить мгновенную скорость игрового объекта, то перемещение п" +
                    "о прямой невозможно", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 19
testRunner.Given("космический корабль находится в точке пространства с координатами (12, 5)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 20
testRunner.And("скорость корабля определить невозможно", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 21
testRunner.When("происходит прямолинейное равномерное движение без деформации", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 22
testRunner.Then("возникает ошибка Exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Если невозможно изменить положение игрового объекта в пространстве, то перемещени" +
            "е по прямой невозможно")]
        [Xunit.TraitAttribute("FeatureTitle", "Перемещение_шатла")]
        [Xunit.TraitAttribute("Description", "Если невозможно изменить положение игрового объекта в пространстве, то перемещени" +
            "е по прямой невозможно")]
        public void ЕслиНевозможноИзменитьПоложениеИгровогоОбъектаВПространствеТоПеремещениеПоПрямойНевозможно()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Если невозможно изменить положение игрового объекта в пространстве, то перемещени" +
                    "е по прямой невозможно", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
testRunner.Given("космический корабль находится в точке пространства с координатами (12, 5)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 26
testRunner.And("имеет мгновенную скорость (-5, 3)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 27
testRunner.And("изменить положение в пространстве космического корабля невозможно", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 28
testRunner.When("происходит прямолинейное равномерное движение без деформации", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 29
testRunner.Then("возникает ошибка Exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Если топлива достаточно, то перемещение по прямой возможно")]
        [Xunit.TraitAttribute("FeatureTitle", "Перемещение_шатла")]
        [Xunit.TraitAttribute("Description", "Если топлива достаточно, то перемещение по прямой возможно")]
        public void ЕслиТопливаДостаточноТоПеремещениеПоПрямойВозможно()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Если топлива достаточно, то перемещение по прямой возможно", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 31
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 32
testRunner.Given("космический корабль имеет топливо в объеме 40 ед", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 33
testRunner.And("имеет скорость расхода топлива при движении 2 ед", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 34
testRunner.When("происходит прямолинейное равномерное движение без деформации", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 35
testRunner.Then("новый объем топлива космического корабля равен 38 ед", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Если недостаточно количества топлива, то перемещение по прямой невозможно")]
        [Xunit.TraitAttribute("FeatureTitle", "Перемещение_шатла")]
        [Xunit.TraitAttribute("Description", "Если недостаточно количества топлива, то перемещение по прямой невозможно")]
        public void ЕслиНедостаточноКоличестваТопливаТоПеремещениеПоПрямойНевозможно()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Если недостаточно количества топлива, то перемещение по прямой невозможно", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 37
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 38
testRunner.Given("космический корабль имеет топливо в объеме 1 ед", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 39
testRunner.And("имеет скорость расхода топлива при движении 2 ед", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 40
testRunner.When("происходит прямолинейное равномерное движение без деформации", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 41
testRunner.Then("возникает ошибка Exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Игровой объект может вращаться вокруг собственной оси")]
        [Xunit.TraitAttribute("FeatureTitle", "Перемещение_шатла")]
        [Xunit.TraitAttribute("Description", "Игровой объект может вращаться вокруг собственной оси")]
        public void ИгровойОбъектМожетВращатьсяВокругСобственнойОси()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Игровой объект может вращаться вокруг собственной оси", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 43
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 44
testRunner.Given("космический корабль имеет угол наклона 45 град к оси OX", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 45
testRunner.And("имеет мгновенную угловую скорость 45 град", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 46
testRunner.When("происходит вращение вокруг собственной оси", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 47
testRunner.Then("угол наклона космического корабля к оси OX составляет 90 град", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Если невозможно определить угол наклона к оси OX космического корабля, то вращени" +
            "е вокруг собственной оси  невозможно")]
        [Xunit.TraitAttribute("FeatureTitle", "Перемещение_шатла")]
        [Xunit.TraitAttribute("Description", "Если невозможно определить угол наклона к оси OX космического корабля, то вращени" +
            "е вокруг собственной оси  невозможно")]
        public void ЕслиНевозможноОпределитьУголНаклонаКОсиOXКосмическогоКорабляТоВращениеВокругСобственнойОсиНевозможно()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Если невозможно определить угол наклона к оси OX космического корабля, то вращени" +
                    "е вокруг собственной оси  невозможно", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 49
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 50
testRunner.Given("космический корабль, угол наклона которого невозможно определить", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 51
testRunner.And("имеет мгновенную угловую скорость 45 град", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 52
testRunner.When("происходит вращение вокруг собственной оси", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 53
testRunner.Then("возникает ошибка Exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Если невозможно определить мгновенную угловую скорость космического корабля, то в" +
            "ращение вокруг собственной оси  невозможно")]
        [Xunit.TraitAttribute("FeatureTitle", "Перемещение_шатла")]
        [Xunit.TraitAttribute("Description", "Если невозможно определить мгновенную угловую скорость космического корабля, то в" +
            "ращение вокруг собственной оси  невозможно")]
        public void ЕслиНевозможноОпределитьМгновеннуюУгловуюСкоростьКосмическогоКорабляТоВращениеВокругСобственнойОсиНевозможно()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Если невозможно определить мгновенную угловую скорость космического корабля, то в" +
                    "ращение вокруг собственной оси  невозможно", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 55
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 56
testRunner.Given("космический корабль имеет угол наклона 45 град к оси OX", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 57
testRunner.And("мгновенную угловую скорость невозможно определить", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 58
testRunner.When("происходит вращение вокруг собственной оси", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 59
testRunner.Then("возникает ошибка Exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Если невозможно установить новый угол наклона космического корабля космического к" +
            "орабля, то вращение вокруг собственной оси  невозможно")]
        [Xunit.TraitAttribute("FeatureTitle", "Перемещение_шатла")]
        [Xunit.TraitAttribute("Description", "Если невозможно установить новый угол наклона космического корабля космического к" +
            "орабля, то вращение вокруг собственной оси  невозможно")]
        public void ЕслиНевозможноУстановитьНовыйУголНаклонаКосмическогоКорабляКосмическогоКорабляТоВращениеВокругСобственнойОсиНевозможно()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Если невозможно установить новый угол наклона космического корабля космического к" +
                    "орабля, то вращение вокруг собственной оси  невозможно", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 61
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 62
testRunner.Given("космический корабль имеет угол наклона 45 град к оси OX", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 63
testRunner.And("имеет мгновенную угловую скорость 45 град", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 64
testRunner.And("невозможно изменить уголд наклона к оси OX космического корабля", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 65
testRunner.When("происходит вращение вокруг собственной оси", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 66
testRunner.Then("возникает ошибка Exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                Перемещение_ШатлаFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                Перемещение_ШатлаFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
