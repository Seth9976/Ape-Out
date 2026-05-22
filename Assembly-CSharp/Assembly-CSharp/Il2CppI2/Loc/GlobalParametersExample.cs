using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppI2.Loc
{
	// Token: 0x02000223 RID: 547
	public class GlobalParametersExample : RegisterGlobalParameters
	{
		// Token: 0x06004253 RID: 16979 RVA: 0x000F65E0 File Offset: 0x000F47E0
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalParametersExample()
		{
			Il2CppClassPointerStore<GlobalParametersExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "GlobalParametersExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalParametersExample>.NativeClassPtr);
			GlobalParametersExample.NativeMethodInfoPtr_GetParameterValue_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParametersExample>.NativeClassPtr, 100669773);
			GlobalParametersExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParametersExample>.NativeClassPtr, 100669774);
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x000F6638 File Offset: 0x000F4838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106559, XrefRangeEnd = 106564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetParameterValue(string ParamName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ParamName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GlobalParametersExample.NativeMethodInfoPtr_GetParameterValue_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x000F668C File Offset: 0x000F488C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlobalParametersExample()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalParametersExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalParametersExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x0002878E File Offset: 0x0002698E
		public GlobalParametersExample(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040028BD RID: 10429
		private static readonly IntPtr NativeMethodInfoPtr_GetParameterValue_Public_Virtual_String_String_0;

		// Token: 0x040028BE RID: 10430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
