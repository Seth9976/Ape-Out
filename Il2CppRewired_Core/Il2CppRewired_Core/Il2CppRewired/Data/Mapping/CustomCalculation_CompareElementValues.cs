using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppRewired.Utils.Classes.Data;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x020000A5 RID: 165
	[Serializable]
	public sealed class CustomCalculation_CompareElementValues : CustomCalculation
	{
		// Token: 0x06001461 RID: 5217 RVA: 0x00079608 File Offset: 0x00077808
		// Note: this type is marked as 'beforefieldinit'.
		static CustomCalculation_CompareElementValues()
		{
			Il2CppClassPointerStore<CustomCalculation_CompareElementValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "CustomCalculation_CompareElementValues");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomCalculation_CompareElementValues>.NativeClassPtr);
			CustomCalculation_CompareElementValues.NativeFieldInfoPtr_resultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCalculation_CompareElementValues>.NativeClassPtr, "resultType");
			CustomCalculation_CompareElementValues.NativeFieldInfoPtr__comparisonType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCalculation_CompareElementValues>.NativeClassPtr, "_comparisonType");
			CustomCalculation_CompareElementValues.NativeMethodInfoPtr_get_ResultType_Internal_Virtual_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation_CompareElementValues>.NativeClassPtr, 100666741);
			CustomCalculation_CompareElementValues.NativeMethodInfoPtr_FGmlJUhppNOoAsicdMOGvcmcvyK_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation_CompareElementValues>.NativeClassPtr, 100666742);
			CustomCalculation_CompareElementValues.NativeMethodInfoPtr_vTTjuYFMZWgbazQMtAdVjGFHoiLN_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation_CompareElementValues>.NativeClassPtr, 100666743);
			CustomCalculation_CompareElementValues.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation_CompareElementValues>.NativeClassPtr, 100666744);
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x000796B0 File Offset: 0x000778B0
		public unsafe override TypeWrapper.DataType ResultType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation_CompareElementValues.NativeMethodInfoPtr_get_ResultType_Internal_Virtual_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x000796EC File Offset: 0x000778EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265382, XrefRangeEnd = 265388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool FGmlJUhppNOoAsicdMOGvcmcvyK()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation_CompareElementValues.NativeMethodInfoPtr_FGmlJUhppNOoAsicdMOGvcmcvyK_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00079728 File Offset: 0x00077928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265399, RefRangeEnd = 265400, XrefRangeStart = 265388, XrefRangeEnd = 265399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float vTTjuYFMZWgbazQMtAdVjGFHoiLN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation_CompareElementValues.NativeMethodInfoPtr_vTTjuYFMZWgbazQMtAdVjGFHoiLN_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00079764 File Offset: 0x00077964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomCalculation_CompareElementValues()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomCalculation_CompareElementValues>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation_CompareElementValues.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00008DCB File Offset: 0x00006FCB
		public CustomCalculation_CompareElementValues(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x000797A0 File Offset: 0x000779A0
		// (set) Token: 0x06001468 RID: 5224 RVA: 0x00008DD4 File Offset: 0x00006FD4
		public unsafe static TypeWrapper.DataType resultType
		{
			get
			{
				TypeWrapper.DataType dataType;
				IL2CPP.il2cpp_field_static_get_value(CustomCalculation_CompareElementValues.NativeFieldInfoPtr_resultType, (void*)(&dataType));
				return dataType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomCalculation_CompareElementValues.NativeFieldInfoPtr_resultType, (void*)(&value));
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x000797BC File Offset: 0x000779BC
		// (set) Token: 0x0600146A RID: 5226 RVA: 0x00008DE2 File Offset: 0x00006FE2
		public unsafe CustomCalculation_CompareElementValues.ComparisonType _comparisonType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomCalculation_CompareElementValues.NativeFieldInfoPtr__comparisonType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomCalculation_CompareElementValues.NativeFieldInfoPtr__comparisonType)) = value;
			}
		}

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeFieldInfoPtr_resultType;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeFieldInfoPtr__comparisonType;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_get_ResultType_Internal_Virtual_get_DataType_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_FGmlJUhppNOoAsicdMOGvcmcvyK_Internal_Virtual_Boolean_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_vTTjuYFMZWgbazQMtAdVjGFHoiLN_Private_Single_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D1 RID: 721
		[OriginalName("Rewired_Core.dll", "", "ComparisonType")]
		public enum ComparisonType
		{
			// Token: 0x040033A4 RID: 13220
			Min,
			// Token: 0x040033A5 RID: 13221
			Max,
			// Token: 0x040033A6 RID: 13222
			MinAbs,
			// Token: 0x040033A7 RID: 13223
			MaxAbs
		}
	}
}
