Imports System.Windows.Forms

Module Program
    <STAThread()>
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New frmSnake())
    End Sub
End Module
