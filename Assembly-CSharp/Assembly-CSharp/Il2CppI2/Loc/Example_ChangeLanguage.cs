using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x02000221 RID: 545
	public class Example_ChangeLanguage : MonoBehaviour
	{
		// Token: 0x06004242 RID: 16962 RVA: 0x000F62AC File Offset: 0x000F44AC
		// Note: this type is marked as 'beforefieldinit'.
		static Example_ChangeLanguage()
		{
			Il2CppClassPointerStore<Example_ChangeLanguage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "Example_ChangeLanguage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Example_ChangeLanguage>.NativeClassPtr);
			Example_ChangeLanguage.NativeMethodInfoPtr_SetLanguage_English_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Example_ChangeLanguage>.NativeClassPtr, 100669766);
			Example_ChangeLanguage.NativeMethodInfoPtr_SetLanguage_French_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Example_ChangeLanguage>.NativeClassPtr, 100669767);
			Example_ChangeLanguage.NativeMethodInfoPtr_SetLanguage_Spanish_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Example_ChangeLanguage>.NativeClassPtr, 100669768);
			Example_ChangeLanguage.NativeMethodInfoPtr_SetLanguage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Example_ChangeLanguage>.NativeClassPtr, 100669769);
			Example_ChangeLanguage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Example_ChangeLanguage>.NativeClassPtr, 100669770);
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x000F6340 File Offset: 0x000F4540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106503, XrefRangeEnd = 106506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLanguage_English()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Example_ChangeLanguage.NativeMethodInfoPtr_SetLanguage_English_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x000F6374 File Offset: 0x000F4574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106506, XrefRangeEnd = 106509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLanguage_French()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Example_ChangeLanguage.NativeMethodInfoPtr_SetLanguage_French_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x000F63A8 File Offset: 0x000F45A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106509, XrefRangeEnd = 106512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLanguage_Spanish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Example_ChangeLanguage.NativeMethodInfoPtr_SetLanguage_Spanish_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x000F63DC File Offset: 0x000F45DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 106519, RefRangeEnd = 106522, XrefRangeStart = 106512, XrefRangeEnd = 106519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLanguage(string LangName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(LangName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Example_ChangeLanguage.NativeMethodInfoPtr_SetLanguage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x000F6420 File Offset: 0x000F4620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Example_ChangeLanguage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Example_ChangeLanguage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Example_ChangeLanguage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x00028710 File Offset: 0x00026910
		public Example_ChangeLanguage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040028B3 RID: 10419
		private static readonly IntPtr NativeMethodInfoPtr_SetLanguage_English_Public_Void_0;

		// Token: 0x040028B4 RID: 10420
		private static readonly IntPtr NativeMethodInfoPtr_SetLanguage_French_Public_Void_0;

		// Token: 0x040028B5 RID: 10421
		private static readonly IntPtr NativeMethodInfoPtr_SetLanguage_Spanish_Public_Void_0;

		// Token: 0x040028B6 RID: 10422
		private static readonly IntPtr NativeMethodInfoPtr_SetLanguage_Public_Void_String_0;

		// Token: 0x040028B7 RID: 10423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
