﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.261
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace NerdSupport.Specs.Done
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class VIsaFragaFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "VisaFraga.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("sv-SE"), "VIsa fraga", "\r\nFör att säkerhetsställa att frågor blir besvarade i tur och ordning\r\nSom Nörd\r\n" +
                    "Ska jag bara se den högst prioriterade frågan", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "VIsa fraga")))
            {
                NerdSupport.Specs.Done.VIsaFragaFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Visa fråga med högst prio")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "VIsa fraga")]
        public virtual void VisaFragaMedHogstPrio()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Visa fråga med högst prio", new string[] {
                        "currentIteration"});
#line 9
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Fråga",
                        "Prioritet"});
            table1.AddRow(new string[] {
                        "Hur uttalas Azure?",
                        "23"});
            table1.AddRow(new string[] {
                        "Vad är molnet?",
                        "10"});
#line 10
 testRunner.Given("att följande frågor finns", ((string)(null)), table1);
#line 15
 testRunner.When("Nörden navigerar till sidan för att besvara frågor");
#line 16
 testRunner.Then("ser nörden frågan om \"Hur uttalas Azure?\" eftersom att den har högst prioritet");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("När två frågor har samma prioritet")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "VIsa fraga")]
        public virtual void NarTvaFragorHarSammaPrioritet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("När två frågor har samma prioritet", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Fråga",
                        "Inskickad",
                        "Prioritet"});
            table2.AddRow(new string[] {
                        "Kommer Microsoft ge bort WP7 som giveaway på techdays?",
                        "2012-04-15",
                        "42"});
            table2.AddRow(new string[] {
                        "Varför används inte Windows ME längre ?",
                        "2000-03-02",
                        "42"});
#line 19
 testRunner.Given("att följande frågor finns", ((string)(null)), table2);
#line 24
 testRunner.When("Nörden navigerar till sidan för att besvara frågor");
#line 25
 testRunner.Then("ser nörden frågan om \"Varför används inte Windows ME längre ?\" eftersom att den ä" +
                    "r äldst");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion