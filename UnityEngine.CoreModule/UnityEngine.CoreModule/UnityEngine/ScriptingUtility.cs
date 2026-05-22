using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000E2 RID: 226
	public class ScriptingUtility : Object
	{
		// Token: 0x0600136A RID: 4970 RVA: 0x0000AE31 File Offset: 0x00009031
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptingUtility()
		{
			Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScriptingUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr);
			ScriptingUtility.NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr, 100664979);
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x0004EDFC File Offset: 0x0004CFFC
		[CallerCount(0)]
		public unsafe static bool IsManagedCodeWorking()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingUtility.NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x0000AE6A File Offset: 0x0000906A
		public ScriptingUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0;

		// Token: 0x020007B9 RID: 1977
		[StructLayout(2)]
		public struct TestClass
		{
			// Token: 0x06002D6A RID: 11626 RVA: 0x0001376B File Offset: 0x0001196B
			// Note: this type is marked as 'beforefieldinit'.
			static TestClass()
			{
				Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr, "TestClass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr);
				ScriptingUtility.TestClass.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr, "value");
			}

			// Token: 0x06002D6B RID: 11627 RVA: 0x0001379F File Offset: 0x0001199F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr, ref this));
			}

			// Token: 0x04001F1F RID: 7967
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04001F20 RID: 7968
			[FieldOffset(0)]
			public int value;
		}
	}
}
