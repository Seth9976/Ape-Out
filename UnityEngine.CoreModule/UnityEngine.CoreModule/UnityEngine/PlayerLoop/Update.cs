using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x02000149 RID: 329
	[StructLayout(2)]
	public struct Update
	{
		// Token: 0x06001982 RID: 6530 RVA: 0x0000D639 File Offset: 0x0000B839
		// Note: this type is marked as 'beforefieldinit'.
		static Update()
		{
			Il2CppClassPointerStore<Update>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "Update");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update>.NativeClassPtr);
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x0000D65E File Offset: 0x0000B85E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update>.NativeClassPtr, ref this));
		}

		// Token: 0x020008F9 RID: 2297
		[StructLayout(2)]
		public struct ScriptRunBehaviourUpdate
		{
			// Token: 0x0600306F RID: 12399 RVA: 0x000148A2 File Offset: 0x00012AA2
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunBehaviourUpdate()
			{
				Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunBehaviourUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr);
			}

			// Token: 0x06003070 RID: 12400 RVA: 0x000148C2 File Offset: 0x00012AC2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008FA RID: 2298
		[StructLayout(2)]
		public struct DirectorUpdate
		{
			// Token: 0x06003071 RID: 12401 RVA: 0x000148D4 File Offset: 0x00012AD4
			// Note: this type is marked as 'beforefieldinit'.
			static DirectorUpdate()
			{
				Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "DirectorUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr);
			}

			// Token: 0x06003072 RID: 12402 RVA: 0x000148F4 File Offset: 0x00012AF4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008FB RID: 2299
		[StructLayout(2)]
		public struct ScriptRunDelayedDynamicFrameRate
		{
			// Token: 0x06003073 RID: 12403 RVA: 0x00014906 File Offset: 0x00012B06
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunDelayedDynamicFrameRate()
			{
				Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunDelayedDynamicFrameRate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr);
			}

			// Token: 0x06003074 RID: 12404 RVA: 0x00014926 File Offset: 0x00012B26
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008FC RID: 2300
		[StructLayout(2)]
		public struct ScriptRunDelayedTasks
		{
			// Token: 0x06003075 RID: 12405 RVA: 0x00014938 File Offset: 0x00012B38
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunDelayedTasks()
			{
				Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunDelayedTasks");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr);
			}

			// Token: 0x06003076 RID: 12406 RVA: 0x00014958 File Offset: 0x00012B58
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr, ref this));
			}
		}
	}
}
