using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000EE RID: 238
	public sealed class WaitForSeconds : YieldInstruction
	{
		// Token: 0x06001402 RID: 5122 RVA: 0x000510E0 File Offset: 0x0004F2E0
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForSeconds()
		{
			Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForSeconds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr);
			WaitForSeconds.NativeFieldInfoPtr_m_Seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr, "m_Seconds");
			WaitForSeconds.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr, 100665063);
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00051138 File Offset: 0x0004F338
		[CallerCount(0)]
		public unsafe WaitForSeconds(float seconds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSeconds.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0000B12E File Offset: 0x0000932E
		public WaitForSeconds(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x00051180 File Offset: 0x0004F380
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x0000B137 File Offset: 0x00009337
		public unsafe float m_Seconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSeconds.NativeFieldInfoPtr_m_Seconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSeconds.NativeFieldInfoPtr_m_Seconds)) = value;
			}
		}

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeFieldInfoPtr_m_Seconds;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
