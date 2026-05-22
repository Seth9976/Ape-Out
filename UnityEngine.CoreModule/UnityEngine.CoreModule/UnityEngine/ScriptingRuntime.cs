using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000252 RID: 594
	public class ScriptingRuntime
	{
		// Token: 0x060021C5 RID: 8645 RVA: 0x00076E24 File Offset: 0x00075024
		public static Il2CppStringArray GetAllUserAssemblies()
		{
			IntPtr intPtr = ScriptingRuntime.GetAllUserAssembliesDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x04001BD6 RID: 7126
		private static readonly ScriptingRuntime.GetAllUserAssembliesDelegate GetAllUserAssembliesDelegateField = IL2CPP.ResolveICall<ScriptingRuntime.GetAllUserAssembliesDelegate>("UnityEngine.ScriptingRuntime::GetAllUserAssemblies");

		// Token: 0x02000B91 RID: 2961
		// (Invoke) Token: 0x06003582 RID: 13698
		private delegate IntPtr GetAllUserAssembliesDelegate();
	}
}
