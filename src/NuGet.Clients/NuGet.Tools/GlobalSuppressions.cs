
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "VSTHRD011:Use AsyncLazy<T>", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.ShowErrorsCommand.#ctor(System.IServiceProvider)")]
[assembly: SuppressMessage("Build", "CA1823:Unused field 'guidNuGetVSEventsPackagePkgString'.", Justification = "<Pending>", Scope = "member", Target = "~F:NuGetVSExtension.GuidList.guidNuGetVSEventsPackagePkgString")]
[assembly: SuppressMessage("Build", "CA1823:Unused field 'LogEntrySource'.", Justification = "<Pending>", Scope = "member", Target = "~F:NuGetVSExtension.OutputConsoleLogger.LogEntrySource")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'Flush' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.DataStreamFromComStream.Flush")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void FontAndColorsRegistrationAttribute.Register(RegistrationContext context)', validate parameter 'context' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.FontAndColorsRegistrationAttribute.Register(Microsoft.VisualStudio.Shell.RegistrationAttribute.RegistrationContext)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void FontAndColorsRegistrationAttribute.Unregister(RegistrationContext context)', validate parameter 'context' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.FontAndColorsRegistrationAttribute.Unregister(Microsoft.VisualStudio.Shell.RegistrationAttribute.RegistrationContext)")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'NuGetPackage.CreateDocWindowAsync(Project, string, IVsHierarchy, uint)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.NuGetPackage.CreateDocWindowAsync(EnvDTE.Project,System.String,Microsoft.VisualStudio.Shell.Interop.IVsHierarchy,System.UInt32)~System.Threading.Tasks.Task{Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame}")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'new PackageManagerWindowPane(control)' before all references to it are out of scope.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.NuGetPackage.CreateDocWindowAsync(EnvDTE.Project,System.String,Microsoft.VisualStudio.Shell.Interop.IVsHierarchy,System.UInt32)~System.Threading.Tasks.Task{Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame}")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'new PackageManagerWindowPane(control)' before all references to it are out of scope.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.NuGetPackage.CreateDocWindowForSolutionAsync~System.Threading.Tasks.Task{Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'int NuGetPackage.LoadUserOptions(IVsSolutionPersistence pPersistence, uint grfLoadOpts)', validate parameter 'pPersistence' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.NuGetPackage.LoadUserOptions(Microsoft.VisualStudio.Shell.Interop.IVsSolutionPersistence,System.UInt32)~System.Int32")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'int NuGetPackage.SaveUserOptions(IVsSolutionPersistence pPersistence)', validate parameter 'pPersistence' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.NuGetPackage.SaveUserOptions(Microsoft.VisualStudio.Shell.Interop.IVsSolutionPersistence)~System.Int32")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'ShowOptionPageSafe' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.NuGetPackage.ShowOptionPageSafe(System.Type)")]
[assembly: SuppressMessage("Build", "CA1507:Use nameof in place of string literal 'menuCommandService'", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.NuGetSearchProvider.#ctor(Microsoft.VisualStudio.Shell.OleMenuCommandService,Microsoft.VisualStudio.Shell.OleMenuCommand,Microsoft.VisualStudio.Shell.OleMenuCommand)")]
[assembly: SuppressMessage("Build", "CA1507:Use nameof in place of string literal 'managePackageForSolutionDialogCommand'", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.NuGetSearchTask.#ctor(NuGetVSExtension.NuGetSearchProvider,System.UInt32,Microsoft.VisualStudio.Shell.Interop.IVsSearchQuery,Microsoft.VisualStudio.Shell.Interop.IVsSearchProviderCallback,Microsoft.VisualStudio.Shell.OleMenuCommand,Microsoft.VisualStudio.Shell.OleMenuCommand)")]
[assembly: SuppressMessage("Build", "CA1507:Use nameof in place of string literal 'provider'", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.NuGetStaticSearchResult.#ctor(System.String,NuGetVSExtension.NuGetSearchProvider,Microsoft.VisualStudio.Shell.OleMenuCommand)")]
[assembly: SuppressMessage("Build", "CA1307:The behavior of 'string.StartsWith(string)' could vary based on the current user's locale settings. Replace this call in 'NuGetVSExtension.NuGetStaticSearchResult.NuGetStaticSearchResult(string, NuGetVSExtension.NuGetSearchProvider, Microsoft.VisualStudio.Shell.OleMenuCommand)' with a call to 'string.StartsWith(string, System.StringComparison)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.NuGetStaticSearchResult.#ctor(System.String,NuGetVSExtension.NuGetSearchProvider,Microsoft.VisualStudio.Shell.OleMenuCommand)")]
[assembly: SuppressMessage("Build", "CA1063:Modify 'OutputConsoleLogger.Dispose' so that it calls Dispose(true), then calls GC.SuppressFinalize on the current object instance ('this' or 'Me' in Visual Basic), and then returns.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.OutputConsoleLogger.Dispose")]
[assembly: SuppressMessage("Build", "CA1816:Change OutputConsoleLogger.Dispose() to call GC.SuppressFinalize(object). This will prevent derived types that introduce a finalizer from needing to re-implement 'IDisposable' to call it.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.OutputConsoleLogger.Dispose")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void OutputConsoleLogger.Log(ILogMessage message)', validate parameter 'message' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.OutputConsoleLogger.Log(NuGet.Common.ILogMessage)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void ProvideExpressLoadKeyAttribute.Register(RegistrationContext context)', validate parameter 'context' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.ProvideExpressLoadKeyAttribute.Register(Microsoft.VisualStudio.Shell.RegistrationAttribute.RegistrationContext)")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'Guid.ToString(string)' could vary based on the current user's locale settings. Replace this call in 'ProvideExpressLoadKeyAttribute.RegKeyName(RegistrationAttribute.RegistrationContext)' with a call to 'Guid.ToString(string, IFormatProvider)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.ProvideExpressLoadKeyAttribute.RegKeyName(Microsoft.VisualStudio.Shell.RegistrationAttribute.RegistrationContext)~System.String")]
[assembly: SuppressMessage("Build", "CA1822:Member RegKeyName does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.ProvideExpressLoadKeyAttribute.RegKeyName(Microsoft.VisualStudio.Shell.RegistrationAttribute.RegistrationContext)~System.String")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'string ProvideExpressLoadKeyAttribute.RegKeyName(RegistrationContext context)', validate parameter 'context' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.ProvideExpressLoadKeyAttribute.RegKeyName(Microsoft.VisualStudio.Shell.RegistrationAttribute.RegistrationContext)~System.String")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void ProvideExpressLoadKeyAttribute.Unregister(RegistrationContext context)', validate parameter 'context' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.ProvideExpressLoadKeyAttribute.Unregister(Microsoft.VisualStudio.Shell.RegistrationAttribute.RegistrationContext)")]
[assembly: SuppressMessage("Build", "CA1303:Method 'ProvideSearchProviderAttribute.ProvideSearchProviderAttribute(Type providerType, string providerName)' passes a literal string as parameter 'message' of a call to 'ArgumentException.ArgumentException(string message)'. Retrieve the following string(s) from a resource table instead: \"'providerName' cannot be null or empty.\".", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.ProvideSearchProviderAttribute.#ctor(System.Type,System.String)")]
[assembly: SuppressMessage("Build", "CA1507:Use nameof in place of string literal 'providerType'", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.ProvideSearchProviderAttribute.#ctor(System.Type,System.String)")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'Guid.ToString(string)' could vary based on the current user's locale settings. Replace this call in 'ProvideSearchProviderAttribute.ProvideSearchProviderAttribute(Type, string)' with a call to 'Guid.ToString(string, IFormatProvider)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.ProvideSearchProviderAttribute.#ctor(System.Type,System.String)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void ProvideSearchProviderAttribute.Register(RegistrationContext context)', validate parameter 'context' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.ProvideSearchProviderAttribute.Register(Microsoft.VisualStudio.Shell.RegistrationAttribute.RegistrationContext)")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'Guid.ToString(string)' could vary based on the current user's locale settings. Replace this call in 'ProvideSearchProviderAttribute.Register(RegistrationAttribute.RegistrationContext)' with a call to 'Guid.ToString(string, IFormatProvider)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.ProvideSearchProviderAttribute.Register(Microsoft.VisualStudio.Shell.RegistrationAttribute.RegistrationContext)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void ProvideSearchProviderAttribute.Unregister(RegistrationContext context)', validate parameter 'context' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.ProvideSearchProviderAttribute.Unregister(Microsoft.VisualStudio.Shell.RegistrationAttribute.RegistrationContext)")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'ProvideSearchProviderAttribute.Unregister(RegistrationAttribute.RegistrationContext)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.ProvideSearchProviderAttribute.Unregister(Microsoft.VisualStudio.Shell.RegistrationAttribute.RegistrationContext)")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'ReadUserOptions' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.SolutionUserOptions.ReadUserOptions(Microsoft.VisualStudio.OLE.Interop.IStream,System.String)~System.Int32")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'WriteUserOptions' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGetVSExtension.SolutionUserOptions.WriteUserOptions(Microsoft.VisualStudio.OLE.Interop.IStream,System.String)~System.Int32")]
[assembly: SuppressMessage("Build", "CA1063:Provide an overridable implementation of Dispose(bool) on 'OutputConsoleLogger' or mark the type as sealed. A call to Dispose(false) should only clean up native resources. A call to Dispose(true) should clean up both managed and native resources.", Justification = "<Pending>", Scope = "type", Target = "~T:NuGetVSExtension.OutputConsoleLogger")]
