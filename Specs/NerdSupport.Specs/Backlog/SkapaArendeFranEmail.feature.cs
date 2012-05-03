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
namespace NerdSupport.Specs.Backlog
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SkapaArendeFranE_MailFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SkapaArendeFranEmail.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("sv-SE"), "Skapa ärende från e-mail", "\r\nFör att underlätta för kunder\r\nSom system\r\nSå ska de kunna skicka in e-mail som" +
                    " genererar ett ärende", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Skapa ärende från e-mail")))
            {
                NerdSupport.Specs.Backlog.SkapaArendeFranE_MailFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Skapa nytt ärende")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skapa ärende från e-mail")]
        public virtual void SkapaNyttArende()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Skapa nytt ärende", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ämne",
                        "Brödtext"});
            table1.AddRow(new string[] {
                        "Problem med Lync",
                        "Hjälp det är panik"});
#line 8
 testRunner.Given("följande e-mail", ((string)(null)), table1);
#line 13
 testRunner.When("Hans skickar in detta");
#line 14
 testRunner.Then("ska ett nytt ärende skapas upp");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Uppdatera befintligt ärende mha id i ämnesrad")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skapa ärende från e-mail")]
        public virtual void UppdateraBefintligtArendeMhaIdIAmnesrad()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Uppdatera befintligt ärende mha id i ämnesrad", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ämne",
                        "Brödtext"});
            table2.AddRow(new string[] {
                        "Mer problem med 502",
                        "Återigen problem :("});
#line 18
 testRunner.Given("följande email", ((string)(null)), table2);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Ämne",
                        "Beskrivning"});
            table3.AddRow(new string[] {
                        "502",
                        "Mer problem med 502",
                        "Återigen problem :("});
#line 22
 testRunner.And("att följande ärenden redan finns registrerade", ((string)(null)), table3);
#line 26
 testRunner.When("Greta skickar emailet");
#line 27
 testRunner.Then("ska det befintliga ärendet uppdateras");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Mail med id utan befintligt ärende")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skapa ärende från e-mail")]
        public virtual void MailMedIdUtanBefintligtArende()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mail med id utan befintligt ärende", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ämne",
                        "Brödtext"});
            table4.AddRow(new string[] {
                        "602 fungerar inte",
                        "Mitt tangentbord är borta"});
#line 30
 testRunner.Given("följande email", ((string)(null)), table4);
#line 34
 testRunner.And("att det inte finns något befintligt ärende med id 602");
#line 35
 testRunner.When("Greta skickar emailet");
#line 36
 testRunner.Then("ska inget ärende skapas");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
