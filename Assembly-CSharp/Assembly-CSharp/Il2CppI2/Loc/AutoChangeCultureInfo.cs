using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x0200025A RID: 602
	public class AutoChangeCultureInfo : MonoBehaviour
	{
		// Token: 0x060045F0 RID: 17904 RVA: 0x0010518C File Offset: 0x0010338C
		// Note: this type is marked as 'beforefieldinit'.
		static AutoChangeCultureInfo()
		{
			Il2CppClassPointerStore<AutoChangeCultureInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "AutoChangeCultureInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoChangeCultureInfo>.NativeClassPtr);
			AutoChangeCultureInfo.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChangeCultureInfo>.NativeClassPtr, 100670357);
			AutoChangeCultureInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChangeCultureInfo>.NativeClassPtr, 100670358);
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x001051E4 File Offset: 0x001033E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114140, XrefRangeEnd = 114153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoChangeCultureInfo.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x00105218 File Offset: 0x00103418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoChangeCultureInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoChangeCultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoChangeCultureInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x00029BB1 File Offset: 0x00027DB1
		public AutoChangeCultureInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B6B RID: 11115
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04002B6C RID: 11116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
