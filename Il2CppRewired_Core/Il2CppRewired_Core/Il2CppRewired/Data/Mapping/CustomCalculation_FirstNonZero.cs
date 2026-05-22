using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppRewired.Utils.Classes.Data;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x020000A6 RID: 166
	[Serializable]
	public sealed class CustomCalculation_FirstNonZero : CustomCalculation
	{
		// Token: 0x0600146B RID: 5227 RVA: 0x000797E4 File Offset: 0x000779E4
		// Note: this type is marked as 'beforefieldinit'.
		static CustomCalculation_FirstNonZero()
		{
			Il2CppClassPointerStore<CustomCalculation_FirstNonZero>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "CustomCalculation_FirstNonZero");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomCalculation_FirstNonZero>.NativeClassPtr);
			CustomCalculation_FirstNonZero.NativeFieldInfoPtr_resultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCalculation_FirstNonZero>.NativeClassPtr, "resultType");
			CustomCalculation_FirstNonZero.NativeMethodInfoPtr_get_ResultType_Internal_Virtual_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation_FirstNonZero>.NativeClassPtr, 100666745);
			CustomCalculation_FirstNonZero.NativeMethodInfoPtr_FGmlJUhppNOoAsicdMOGvcmcvyK_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation_FirstNonZero>.NativeClassPtr, 100666746);
			CustomCalculation_FirstNonZero.NativeMethodInfoPtr_vTTjuYFMZWgbazQMtAdVjGFHoiLN_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation_FirstNonZero>.NativeClassPtr, 100666747);
			CustomCalculation_FirstNonZero.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation_FirstNonZero>.NativeClassPtr, 100666748);
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x00079878 File Offset: 0x00077A78
		public unsafe override TypeWrapper.DataType ResultType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation_FirstNonZero.NativeMethodInfoPtr_get_ResultType_Internal_Virtual_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x000798B4 File Offset: 0x00077AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265400, XrefRangeEnd = 265409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool FGmlJUhppNOoAsicdMOGvcmcvyK()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation_FirstNonZero.NativeMethodInfoPtr_FGmlJUhppNOoAsicdMOGvcmcvyK_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x000798F0 File Offset: 0x00077AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265409, XrefRangeEnd = 265411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float vTTjuYFMZWgbazQMtAdVjGFHoiLN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation_FirstNonZero.NativeMethodInfoPtr_vTTjuYFMZWgbazQMtAdVjGFHoiLN_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0007992C File Offset: 0x00077B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomCalculation_FirstNonZero()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomCalculation_FirstNonZero>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation_FirstNonZero.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00008DFD File Offset: 0x00006FFD
		public CustomCalculation_FirstNonZero(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x00079968 File Offset: 0x00077B68
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x00008E06 File Offset: 0x00007006
		public unsafe static TypeWrapper.DataType resultType
		{
			get
			{
				TypeWrapper.DataType dataType;
				IL2CPP.il2cpp_field_static_get_value(CustomCalculation_FirstNonZero.NativeFieldInfoPtr_resultType, (void*)(&dataType));
				return dataType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomCalculation_FirstNonZero.NativeFieldInfoPtr_resultType, (void*)(&value));
			}
		}

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeFieldInfoPtr_resultType;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_get_ResultType_Internal_Virtual_get_DataType_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_FGmlJUhppNOoAsicdMOGvcmcvyK_Internal_Virtual_Boolean_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_vTTjuYFMZWgbazQMtAdVjGFHoiLN_Private_Single_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
