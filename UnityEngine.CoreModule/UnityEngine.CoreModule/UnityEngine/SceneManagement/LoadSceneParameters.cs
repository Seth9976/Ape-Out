using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000141 RID: 321
	[Serializable]
	[StructLayout(2)]
	public struct LoadSceneParameters
	{
		// Token: 0x06001956 RID: 6486 RVA: 0x0006191C File Offset: 0x0005FB1C
		// Note: this type is marked as 'beforefieldinit'.
		static LoadSceneParameters()
		{
			Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "LoadSceneParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr);
			LoadSceneParameters.NativeFieldInfoPtr_m_LoadSceneMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, "m_LoadSceneMode");
			LoadSceneParameters.NativeFieldInfoPtr_m_LocalPhysicsMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, "m_LocalPhysicsMode");
			LoadSceneParameters.NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, 100665639);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00061988 File Offset: 0x0005FB88
		[CallerCount(0)]
		public unsafe LoadSceneParameters(LoadSceneMode mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadSceneParameters.NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x0000D3A8 File Offset: 0x0000B5A8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, ref this));
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x000619BC File Offset: 0x0005FBBC
		// (set) Token: 0x0600195A RID: 6490 RVA: 0x0000D3BA File Offset: 0x0000B5BA
		public LoadSceneMode loadSceneMode
		{
			get
			{
				return this.m_LoadSceneMode;
			}
			set
			{
				this.m_LoadSceneMode = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x000619D4 File Offset: 0x0005FBD4
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x0000D3C4 File Offset: 0x0000B5C4
		public LocalPhysicsMode localPhysicsMode
		{
			get
			{
				return this.m_LocalPhysicsMode;
			}
			set
			{
				this.m_LocalPhysicsMode = value;
			}
		}

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadSceneMode;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalPhysicsMode;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0;

		// Token: 0x04001376 RID: 4982
		[FieldOffset(0)]
		public LoadSceneMode m_LoadSceneMode;

		// Token: 0x04001377 RID: 4983
		[FieldOffset(4)]
		public LocalPhysicsMode m_LocalPhysicsMode;
	}
}
