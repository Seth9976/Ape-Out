using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x02000227 RID: 551
	public class ToggleLanguage : MonoBehaviour
	{
		// Token: 0x06004272 RID: 17010 RVA: 0x000F6CD0 File Offset: 0x000F4ED0
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleLanguage()
		{
			Il2CppClassPointerStore<ToggleLanguage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "ToggleLanguage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleLanguage>.NativeClassPtr);
			ToggleLanguage.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleLanguage>.NativeClassPtr, 100669790);
			ToggleLanguage.NativeMethodInfoPtr_test_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleLanguage>.NativeClassPtr, 100669791);
			ToggleLanguage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleLanguage>.NativeClassPtr, 100669792);
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x000F6D3C File Offset: 0x000F4F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106797, XrefRangeEnd = 106800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleLanguage.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x000F6D70 File Offset: 0x000F4F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106800, XrefRangeEnd = 106815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void test()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleLanguage.NativeMethodInfoPtr_test_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x000F6DA4 File Offset: 0x000F4FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleLanguage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleLanguage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleLanguage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004276 RID: 17014 RVA: 0x00028844 File Offset: 0x00026A44
		public ToggleLanguage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040028D1 RID: 10449
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040028D2 RID: 10450
		private static readonly IntPtr NativeMethodInfoPtr_test_Private_Void_0;

		// Token: 0x040028D3 RID: 10451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
