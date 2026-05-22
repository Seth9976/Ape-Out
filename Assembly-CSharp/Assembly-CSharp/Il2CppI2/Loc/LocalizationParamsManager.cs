using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x02000260 RID: 608
	public class LocalizationParamsManager : MonoBehaviour
	{
		// Token: 0x06004623 RID: 17955 RVA: 0x00105D44 File Offset: 0x00103F44
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizationParamsManager()
		{
			Il2CppClassPointerStore<LocalizationParamsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizationParamsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationParamsManager>.NativeClassPtr);
			LocalizationParamsManager.NativeFieldInfoPtr__Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationParamsManager>.NativeClassPtr, "_Params");
			LocalizationParamsManager.NativeFieldInfoPtr__IsGlobalManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationParamsManager>.NativeClassPtr, "_IsGlobalManager");
			LocalizationParamsManager.NativeMethodInfoPtr_GetParameterValue_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationParamsManager>.NativeClassPtr, 100670392);
			LocalizationParamsManager.NativeMethodInfoPtr_SetParameterValue_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationParamsManager>.NativeClassPtr, 100670393);
			LocalizationParamsManager.NativeMethodInfoPtr_OnLocalize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationParamsManager>.NativeClassPtr, 100670394);
			LocalizationParamsManager.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationParamsManager>.NativeClassPtr, 100670395);
			LocalizationParamsManager.NativeMethodInfoPtr_DoAutoRegister_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationParamsManager>.NativeClassPtr, 100670396);
			LocalizationParamsManager.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationParamsManager>.NativeClassPtr, 100670397);
			LocalizationParamsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationParamsManager>.NativeClassPtr, 100670398);
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x00105E28 File Offset: 0x00104028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114527, XrefRangeEnd = 114529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetParameterValue(string ParamName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ParamName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationParamsManager.NativeMethodInfoPtr_GetParameterValue_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x00105E70 File Offset: 0x00104070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114529, XrefRangeEnd = 114552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ParamName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ParamValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationParamsManager.NativeMethodInfoPtr_SetParameterValue_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x00105ED4 File Offset: 0x001040D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114552, XrefRangeEnd = 114568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationParamsManager.NativeMethodInfoPtr_OnLocalize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x00105F08 File Offset: 0x00104108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114568, XrefRangeEnd = 114582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationParamsManager.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x00105F44 File Offset: 0x00104144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114582, XrefRangeEnd = 114596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoAutoRegister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationParamsManager.NativeMethodInfoPtr_DoAutoRegister_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x00105F78 File Offset: 0x00104178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114596, XrefRangeEnd = 114602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationParamsManager.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x00105FAC File Offset: 0x001041AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114602, XrefRangeEnd = 114615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizationParamsManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationParamsManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationParamsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x00029C7D File Offset: 0x00027E7D
		public LocalizationParamsManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x0600462C RID: 17964 RVA: 0x00105FE8 File Offset: 0x001041E8
		// (set) Token: 0x0600462D RID: 17965 RVA: 0x00029C86 File Offset: 0x00027E86
		public unsafe List<LocalizationParamsManager.ParamValue> _Params
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationParamsManager.NativeFieldInfoPtr__Params);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalizationParamsManager.ParamValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationParamsManager.NativeFieldInfoPtr__Params), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x0600462E RID: 17966 RVA: 0x00106018 File Offset: 0x00104218
		// (set) Token: 0x0600462F RID: 17967 RVA: 0x00029CA5 File Offset: 0x00027EA5
		public unsafe bool _IsGlobalManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationParamsManager.NativeFieldInfoPtr__IsGlobalManager);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationParamsManager.NativeFieldInfoPtr__IsGlobalManager)) = value;
			}
		}

		// Token: 0x04002B8D RID: 11149
		private static readonly IntPtr NativeFieldInfoPtr__Params;

		// Token: 0x04002B8E RID: 11150
		private static readonly IntPtr NativeFieldInfoPtr__IsGlobalManager;

		// Token: 0x04002B8F RID: 11151
		private static readonly IntPtr NativeMethodInfoPtr_GetParameterValue_Public_Virtual_Final_New_String_String_0;

		// Token: 0x04002B90 RID: 11152
		private static readonly IntPtr NativeMethodInfoPtr_SetParameterValue_Public_Void_String_String_Boolean_0;

		// Token: 0x04002B91 RID: 11153
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalize_Public_Void_0;

		// Token: 0x04002B92 RID: 11154
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0;

		// Token: 0x04002B93 RID: 11155
		private static readonly IntPtr NativeMethodInfoPtr_DoAutoRegister_Public_Void_0;

		// Token: 0x04002B94 RID: 11156
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x04002B95 RID: 11157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003DB RID: 987
		[Serializable]
		public sealed class ParamValue : ValueType
		{
			// Token: 0x06005A93 RID: 23187 RVA: 0x00147284 File Offset: 0x00145484
			// Note: this type is marked as 'beforefieldinit'.
			static ParamValue()
			{
				Il2CppClassPointerStore<LocalizationParamsManager.ParamValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizationParamsManager>.NativeClassPtr, "ParamValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationParamsManager.ParamValue>.NativeClassPtr);
				LocalizationParamsManager.ParamValue.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationParamsManager.ParamValue>.NativeClassPtr, "Name");
				LocalizationParamsManager.ParamValue.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationParamsManager.ParamValue>.NativeClassPtr, "Value");
			}

			// Token: 0x06005A94 RID: 23188 RVA: 0x00033BA0 File Offset: 0x00031DA0
			public ParamValue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005A95 RID: 23189 RVA: 0x00033BA9 File Offset: 0x00031DA9
			public ParamValue()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationParamsManager.ParamValue>.NativeClassPtr))
			{
			}

			// Token: 0x170020F7 RID: 8439
			// (get) Token: 0x06005A96 RID: 23190 RVA: 0x001472D8 File Offset: 0x001454D8
			// (set) Token: 0x06005A97 RID: 23191 RVA: 0x00033BBB File Offset: 0x00031DBB
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationParamsManager.ParamValue.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationParamsManager.ParamValue.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170020F8 RID: 8440
			// (get) Token: 0x06005A98 RID: 23192 RVA: 0x00147300 File Offset: 0x00145500
			// (set) Token: 0x06005A99 RID: 23193 RVA: 0x00033BDA File Offset: 0x00031DDA
			public unsafe string Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationParamsManager.ParamValue.NativeFieldInfoPtr_Value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationParamsManager.ParamValue.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003C28 RID: 15400
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04003C29 RID: 15401
			private static readonly IntPtr NativeFieldInfoPtr_Value;
		}
	}
}
