﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestGetCurrentDate()
        Assert.AreEqual(DateTime.Now.Date, QuickDate.Calendar.GetCurrentDate())
    End Sub

End Class