using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x0200023A RID: 570
	public class LanguageSource : MonoBehaviour
	{
		// Token: 0x06004352 RID: 17234 RVA: 0x000FA2B0 File Offset: 0x000F84B0
		// Note: this type is marked as 'beforefieldinit'.
		static LanguageSource()
		{
			Il2CppClassPointerStore<LanguageSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LanguageSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr);
			LanguageSource.NativeFieldInfoPtr_mSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "mSource");
			LanguageSource.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "version");
			LanguageSource.NativeFieldInfoPtr_NeverDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "NeverDestroy");
			LanguageSource.NativeFieldInfoPtr_UserAgreesToHaveItOnTheScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "UserAgreesToHaveItOnTheScene");
			LanguageSource.NativeFieldInfoPtr_UserAgreesToHaveItInsideThePluginsFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "UserAgreesToHaveItInsideThePluginsFolder");
			LanguageSource.NativeFieldInfoPtr_GoogleLiveSyncIsUptoDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "GoogleLiveSyncIsUptoDate");
			LanguageSource.NativeFieldInfoPtr_Assets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "Assets");
			LanguageSource.NativeFieldInfoPtr_Google_WebServiceURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "Google_WebServiceURL");
			LanguageSource.NativeFieldInfoPtr_Google_SpreadsheetKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "Google_SpreadsheetKey");
			LanguageSource.NativeFieldInfoPtr_Google_SpreadsheetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "Google_SpreadsheetName");
			LanguageSource.NativeFieldInfoPtr_Google_LastUpdatedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "Google_LastUpdatedVersion");
			LanguageSource.NativeFieldInfoPtr_GoogleUpdateFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "GoogleUpdateFrequency");
			LanguageSource.NativeFieldInfoPtr_GoogleUpdateDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "GoogleUpdateDelay");
			LanguageSource.NativeFieldInfoPtr_Event_OnSourceUpdateFromGoogle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "Event_OnSourceUpdateFromGoogle");
			LanguageSource.NativeFieldInfoPtr_mLanguages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "mLanguages");
			LanguageSource.NativeFieldInfoPtr_IgnoreDeviceLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "IgnoreDeviceLanguage");
			LanguageSource.NativeFieldInfoPtr__AllowUnloadingLanguages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "_AllowUnloadingLanguages");
			LanguageSource.NativeFieldInfoPtr_mTerms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "mTerms");
			LanguageSource.NativeFieldInfoPtr_CaseInsensitiveTerms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "CaseInsensitiveTerms");
			LanguageSource.NativeFieldInfoPtr_OnMissingTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "OnMissingTranslation");
			LanguageSource.NativeFieldInfoPtr_mTerm_AppName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "mTerm_AppName");
			LanguageSource.NativeMethodInfoPtr_get_SourceData_Public_Virtual_Final_New_get_LanguageSourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, 100669923);
			LanguageSource.NativeMethodInfoPtr_set_SourceData_Public_Virtual_Final_New_set_Void_LanguageSourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, 100669924);
			LanguageSource.NativeMethodInfoPtr_add_Event_OnSourceUpdateFromGoogle_Public_add_Void_fnOnSourceUpdated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, 100669925);
			LanguageSource.NativeMethodInfoPtr_remove_Event_OnSourceUpdateFromGoogle_Public_rem_Void_fnOnSourceUpdated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, 100669926);
			LanguageSource.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, 100669927);
			LanguageSource.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, 100669928);
			LanguageSource.NativeMethodInfoPtr_GetSourceName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, 100669929);
			LanguageSource.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, 100669930);
			LanguageSource.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, 100669931);
			LanguageSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, 100669932);
		}

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x06004353 RID: 17235 RVA: 0x000FA54C File Offset: 0x000F874C
		// (set) Token: 0x06004354 RID: 17236 RVA: 0x000FA58C File Offset: 0x000F878C
		public unsafe virtual LanguageSourceData SourceData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSource.NativeMethodInfoPtr_get_SourceData_Public_Virtual_Final_New_get_LanguageSourceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageSourceData>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSource.NativeMethodInfoPtr_set_SourceData_Public_Virtual_Final_New_set_Void_LanguageSourceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x000FA5D0 File Offset: 0x000F87D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108723, XrefRangeEnd = 108726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Event_OnSourceUpdateFromGoogle(LanguageSource.fnOnSourceUpdated value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSource.NativeMethodInfoPtr_add_Event_OnSourceUpdateFromGoogle_Public_add_Void_fnOnSourceUpdated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x000FA614 File Offset: 0x000F8814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108726, XrefRangeEnd = 108729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Event_OnSourceUpdateFromGoogle(LanguageSource.fnOnSourceUpdated value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSource.NativeMethodInfoPtr_remove_Event_OnSourceUpdateFromGoogle_Public_rem_Void_fnOnSourceUpdated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x000FA658 File Offset: 0x000F8858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108729, XrefRangeEnd = 108737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSource.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x000FA68C File Offset: 0x000F888C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108737, XrefRangeEnd = 108741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSource.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x000FA6C0 File Offset: 0x000F88C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108741, XrefRangeEnd = 108773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSourceName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSource.NativeMethodInfoPtr_GetSourceName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x000FA6F8 File Offset: 0x000F88F8
		[CallerCount(0)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSource.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x000FA72C File Offset: 0x000F892C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108773, XrefRangeEnd = 108801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSource.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x000FA760 File Offset: 0x000F8960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108801, XrefRangeEnd = 108826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LanguageSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x00028DB3 File Offset: 0x00026FB3
		public LanguageSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x0600435E RID: 17246 RVA: 0x000FA79C File Offset: 0x000F899C
		// (set) Token: 0x0600435F RID: 17247 RVA: 0x00028DBC File Offset: 0x00026FBC
		public unsafe LanguageSourceData mSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_mSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LanguageSourceData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_mSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x06004360 RID: 17248 RVA: 0x000FA7CC File Offset: 0x000F89CC
		// (set) Token: 0x06004361 RID: 17249 RVA: 0x00028DDB File Offset: 0x00026FDB
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06004362 RID: 17250 RVA: 0x000FA7F4 File Offset: 0x000F89F4
		// (set) Token: 0x06004363 RID: 17251 RVA: 0x00028DF6 File Offset: 0x00026FF6
		public unsafe bool NeverDestroy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_NeverDestroy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_NeverDestroy)) = value;
			}
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06004364 RID: 17252 RVA: 0x000FA81C File Offset: 0x000F8A1C
		// (set) Token: 0x06004365 RID: 17253 RVA: 0x00028E11 File Offset: 0x00027011
		public unsafe bool UserAgreesToHaveItOnTheScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_UserAgreesToHaveItOnTheScene);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_UserAgreesToHaveItOnTheScene)) = value;
			}
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x06004366 RID: 17254 RVA: 0x000FA844 File Offset: 0x000F8A44
		// (set) Token: 0x06004367 RID: 17255 RVA: 0x00028E2C File Offset: 0x0002702C
		public unsafe bool UserAgreesToHaveItInsideThePluginsFolder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_UserAgreesToHaveItInsideThePluginsFolder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_UserAgreesToHaveItInsideThePluginsFolder)) = value;
			}
		}

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06004368 RID: 17256 RVA: 0x000FA86C File Offset: 0x000F8A6C
		// (set) Token: 0x06004369 RID: 17257 RVA: 0x00028E47 File Offset: 0x00027047
		public unsafe bool GoogleLiveSyncIsUptoDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_GoogleLiveSyncIsUptoDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_GoogleLiveSyncIsUptoDate)) = value;
			}
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x0600436A RID: 17258 RVA: 0x000FA894 File Offset: 0x000F8A94
		// (set) Token: 0x0600436B RID: 17259 RVA: 0x00028E62 File Offset: 0x00027062
		public unsafe List<global::UnityEngine.Object> Assets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_Assets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_Assets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x0600436C RID: 17260 RVA: 0x000FA8C4 File Offset: 0x000F8AC4
		// (set) Token: 0x0600436D RID: 17261 RVA: 0x00028E81 File Offset: 0x00027081
		public unsafe string Google_WebServiceURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_Google_WebServiceURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_Google_WebServiceURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x0600436E RID: 17262 RVA: 0x000FA8EC File Offset: 0x000F8AEC
		// (set) Token: 0x0600436F RID: 17263 RVA: 0x00028EA0 File Offset: 0x000270A0
		public unsafe string Google_SpreadsheetKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_Google_SpreadsheetKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_Google_SpreadsheetKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x06004370 RID: 17264 RVA: 0x000FA914 File Offset: 0x000F8B14
		// (set) Token: 0x06004371 RID: 17265 RVA: 0x00028EBF File Offset: 0x000270BF
		public unsafe string Google_SpreadsheetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_Google_SpreadsheetName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_Google_SpreadsheetName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x06004372 RID: 17266 RVA: 0x000FA93C File Offset: 0x000F8B3C
		// (set) Token: 0x06004373 RID: 17267 RVA: 0x00028EDE File Offset: 0x000270DE
		public unsafe string Google_LastUpdatedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_Google_LastUpdatedVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_Google_LastUpdatedVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x06004374 RID: 17268 RVA: 0x000FA964 File Offset: 0x000F8B64
		// (set) Token: 0x06004375 RID: 17269 RVA: 0x00028EFD File Offset: 0x000270FD
		public unsafe LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_GoogleUpdateFrequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_GoogleUpdateFrequency)) = value;
			}
		}

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x06004376 RID: 17270 RVA: 0x000FA98C File Offset: 0x000F8B8C
		// (set) Token: 0x06004377 RID: 17271 RVA: 0x00028F18 File Offset: 0x00027118
		public unsafe float GoogleUpdateDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_GoogleUpdateDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_GoogleUpdateDelay)) = value;
			}
		}

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x06004378 RID: 17272 RVA: 0x000FA9B4 File Offset: 0x000F8BB4
		// (set) Token: 0x06004379 RID: 17273 RVA: 0x00028F33 File Offset: 0x00027133
		public unsafe LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_Event_OnSourceUpdateFromGoogle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LanguageSource.fnOnSourceUpdated>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_Event_OnSourceUpdateFromGoogle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x0600437A RID: 17274 RVA: 0x000FA9E4 File Offset: 0x000F8BE4
		// (set) Token: 0x0600437B RID: 17275 RVA: 0x00028F52 File Offset: 0x00027152
		public unsafe List<LanguageData> mLanguages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_mLanguages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LanguageData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_mLanguages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x0600437C RID: 17276 RVA: 0x000FAA14 File Offset: 0x000F8C14
		// (set) Token: 0x0600437D RID: 17277 RVA: 0x00028F71 File Offset: 0x00027171
		public unsafe bool IgnoreDeviceLanguage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_IgnoreDeviceLanguage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_IgnoreDeviceLanguage)) = value;
			}
		}

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x0600437E RID: 17278 RVA: 0x000FAA3C File Offset: 0x000F8C3C
		// (set) Token: 0x0600437F RID: 17279 RVA: 0x00028F8C File Offset: 0x0002718C
		public unsafe LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr__AllowUnloadingLanguages);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr__AllowUnloadingLanguages)) = value;
			}
		}

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x06004380 RID: 17280 RVA: 0x000FAA64 File Offset: 0x000F8C64
		// (set) Token: 0x06004381 RID: 17281 RVA: 0x00028FA7 File Offset: 0x000271A7
		public unsafe List<TermData> mTerms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_mTerms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TermData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_mTerms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x06004382 RID: 17282 RVA: 0x000FAA94 File Offset: 0x000F8C94
		// (set) Token: 0x06004383 RID: 17283 RVA: 0x00028FC6 File Offset: 0x000271C6
		public unsafe bool CaseInsensitiveTerms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_CaseInsensitiveTerms);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_CaseInsensitiveTerms)) = value;
			}
		}

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x06004384 RID: 17284 RVA: 0x000FAABC File Offset: 0x000F8CBC
		// (set) Token: 0x06004385 RID: 17285 RVA: 0x00028FE1 File Offset: 0x000271E1
		public unsafe LanguageSourceData.MissingTranslationAction OnMissingTranslation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_OnMissingTranslation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_OnMissingTranslation)) = value;
			}
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x06004386 RID: 17286 RVA: 0x000FAAE4 File Offset: 0x000F8CE4
		// (set) Token: 0x06004387 RID: 17287 RVA: 0x00028FFC File Offset: 0x000271FC
		public unsafe string mTerm_AppName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_mTerm_AppName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageSource.NativeFieldInfoPtr_mTerm_AppName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002971 RID: 10609
		private static readonly IntPtr NativeFieldInfoPtr_mSource;

		// Token: 0x04002972 RID: 10610
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04002973 RID: 10611
		private static readonly IntPtr NativeFieldInfoPtr_NeverDestroy;

		// Token: 0x04002974 RID: 10612
		private static readonly IntPtr NativeFieldInfoPtr_UserAgreesToHaveItOnTheScene;

		// Token: 0x04002975 RID: 10613
		private static readonly IntPtr NativeFieldInfoPtr_UserAgreesToHaveItInsideThePluginsFolder;

		// Token: 0x04002976 RID: 10614
		private static readonly IntPtr NativeFieldInfoPtr_GoogleLiveSyncIsUptoDate;

		// Token: 0x04002977 RID: 10615
		private static readonly IntPtr NativeFieldInfoPtr_Assets;

		// Token: 0x04002978 RID: 10616
		private static readonly IntPtr NativeFieldInfoPtr_Google_WebServiceURL;

		// Token: 0x04002979 RID: 10617
		private static readonly IntPtr NativeFieldInfoPtr_Google_SpreadsheetKey;

		// Token: 0x0400297A RID: 10618
		private static readonly IntPtr NativeFieldInfoPtr_Google_SpreadsheetName;

		// Token: 0x0400297B RID: 10619
		private static readonly IntPtr NativeFieldInfoPtr_Google_LastUpdatedVersion;

		// Token: 0x0400297C RID: 10620
		private static readonly IntPtr NativeFieldInfoPtr_GoogleUpdateFrequency;

		// Token: 0x0400297D RID: 10621
		private static readonly IntPtr NativeFieldInfoPtr_GoogleUpdateDelay;

		// Token: 0x0400297E RID: 10622
		private static readonly IntPtr NativeFieldInfoPtr_Event_OnSourceUpdateFromGoogle;

		// Token: 0x0400297F RID: 10623
		private static readonly IntPtr NativeFieldInfoPtr_mLanguages;

		// Token: 0x04002980 RID: 10624
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreDeviceLanguage;

		// Token: 0x04002981 RID: 10625
		private static readonly IntPtr NativeFieldInfoPtr__AllowUnloadingLanguages;

		// Token: 0x04002982 RID: 10626
		private static readonly IntPtr NativeFieldInfoPtr_mTerms;

		// Token: 0x04002983 RID: 10627
		private static readonly IntPtr NativeFieldInfoPtr_CaseInsensitiveTerms;

		// Token: 0x04002984 RID: 10628
		private static readonly IntPtr NativeFieldInfoPtr_OnMissingTranslation;

		// Token: 0x04002985 RID: 10629
		private static readonly IntPtr NativeFieldInfoPtr_mTerm_AppName;

		// Token: 0x04002986 RID: 10630
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceData_Public_Virtual_Final_New_get_LanguageSourceData_0;

		// Token: 0x04002987 RID: 10631
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceData_Public_Virtual_Final_New_set_Void_LanguageSourceData_0;

		// Token: 0x04002988 RID: 10632
		private static readonly IntPtr NativeMethodInfoPtr_add_Event_OnSourceUpdateFromGoogle_Public_add_Void_fnOnSourceUpdated_0;

		// Token: 0x04002989 RID: 10633
		private static readonly IntPtr NativeMethodInfoPtr_remove_Event_OnSourceUpdateFromGoogle_Public_rem_Void_fnOnSourceUpdated_0;

		// Token: 0x0400298A RID: 10634
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400298B RID: 10635
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400298C RID: 10636
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceName_Public_String_0;

		// Token: 0x0400298D RID: 10637
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400298E RID: 10638
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400298F RID: 10639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003BD RID: 957
		public sealed class fnOnSourceUpdated : MulticastDelegate
		{
			// Token: 0x060059D2 RID: 22994 RVA: 0x00144C6C File Offset: 0x00142E6C
			// Note: this type is marked as 'beforefieldinit'.
			static fnOnSourceUpdated()
			{
				Il2CppClassPointerStore<LanguageSource.fnOnSourceUpdated>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LanguageSource>.NativeClassPtr, "fnOnSourceUpdated");
				LanguageSource.fnOnSourceUpdated.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSource.fnOnSourceUpdated>.NativeClassPtr, 100669933);
				LanguageSource.fnOnSourceUpdated.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LanguageSourceData_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSource.fnOnSourceUpdated>.NativeClassPtr, 100669934);
				LanguageSource.fnOnSourceUpdated.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LanguageSourceData_Boolean_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSource.fnOnSourceUpdated>.NativeClassPtr, 100669935);
				LanguageSource.fnOnSourceUpdated.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageSource.fnOnSourceUpdated>.NativeClassPtr, 100669936);
			}

			// Token: 0x060059D3 RID: 22995 RVA: 0x00144CE0 File Offset: 0x00142EE0
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe fnOnSourceUpdated(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageSource.fnOnSourceUpdated>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSource.fnOnSourceUpdated.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059D4 RID: 22996 RVA: 0x00144D3C File Offset: 0x00142F3C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 108717, RefRangeEnd = 108719, XrefRangeStart = 108717, XrefRangeEnd = 108717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(LanguageSourceData source, bool ReceivedNewData, string errorMsg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ReceivedNewData;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSource.fnOnSourceUpdated.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LanguageSourceData_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059D5 RID: 22997 RVA: 0x00144DA0 File Offset: 0x00142FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108719, XrefRangeEnd = 108723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(LanguageSourceData source, bool ReceivedNewData, string errorMsg, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ReceivedNewData;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMsg);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSource.fnOnSourceUpdated.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LanguageSourceData_Boolean_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060059D6 RID: 22998 RVA: 0x00144E38 File Offset: 0x00143038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageSource.fnOnSourceUpdated.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060059D7 RID: 22999 RVA: 0x000336C0 File Offset: 0x000318C0
			public fnOnSourceUpdated(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060059D8 RID: 23000 RVA: 0x000336C9 File Offset: 0x000318C9
			public static implicit operator LanguageSource.fnOnSourceUpdated(Action<LanguageSourceData, bool, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<LanguageSource.fnOnSourceUpdated>(A_0);
			}

			// Token: 0x060059D9 RID: 23001 RVA: 0x000336D1 File Offset: 0x000318D1
			public static LanguageSource.fnOnSourceUpdated operator +(LanguageSource.fnOnSourceUpdated A_0, LanguageSource.fnOnSourceUpdated A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LanguageSource.fnOnSourceUpdated>();
			}

			// Token: 0x060059DA RID: 23002 RVA: 0x000336DF File Offset: 0x000318DF
			public static LanguageSource.fnOnSourceUpdated operator -(LanguageSource.fnOnSourceUpdated A_0, LanguageSource.fnOnSourceUpdated A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LanguageSource.fnOnSourceUpdated>();
				}
				return delegate2;
			}

			// Token: 0x04003BA1 RID: 15265
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003BA2 RID: 15266
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LanguageSourceData_Boolean_String_0;

			// Token: 0x04003BA3 RID: 15267
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LanguageSourceData_Boolean_String_AsyncCallback_Object_0;

			// Token: 0x04003BA4 RID: 15268
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
