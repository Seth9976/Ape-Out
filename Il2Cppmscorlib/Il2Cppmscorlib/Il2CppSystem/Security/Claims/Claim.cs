using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security.Claims
{
	// Token: 0x020002D3 RID: 723
	[Serializable]
	public class Claim : Object
	{
		// Token: 0x060030D9 RID: 12505 RVA: 0x000F6558 File Offset: 0x000F4758
		// Note: this type is marked as 'beforefieldinit'.
		static Claim()
		{
			Il2CppClassPointerStore<Claim>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Claims", "Claim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Claim>.NativeClassPtr);
			Claim.NativeFieldInfoPtr_m_issuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_issuer");
			Claim.NativeFieldInfoPtr_m_originalIssuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_originalIssuer");
			Claim.NativeFieldInfoPtr_m_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_type");
			Claim.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_value");
			Claim.NativeFieldInfoPtr_m_valueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_valueType");
			Claim.NativeFieldInfoPtr_m_userSerializationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_userSerializationData");
			Claim.NativeFieldInfoPtr_m_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_properties");
			Claim.NativeFieldInfoPtr_m_propertyLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_propertyLock");
			Claim.NativeFieldInfoPtr_m_subject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Claim>.NativeClassPtr, "m_subject");
			Claim.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100671052);
			Claim.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_String_ClaimsIdentity_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100671053);
			Claim.NativeMethodInfoPtr__ctor_Protected_Void_Claim_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100671054);
			Claim.NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100671055);
			Claim.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100671056);
			Claim.NativeMethodInfoPtr_get_Subject_Public_get_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100671057);
			Claim.NativeMethodInfoPtr_set_Subject_Internal_set_Void_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100671058);
			Claim.NativeMethodInfoPtr_get_Type_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100671059);
			Claim.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100671060);
			Claim.NativeMethodInfoPtr_Clone_Public_Virtual_New_Claim_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100671061);
			Claim.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Claim>.NativeClassPtr, 100671062);
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x000F6718 File Offset: 0x000F4918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208695, RefRangeEnd = 208696, XrefRangeStart = 208681, XrefRangeEnd = 208695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Claim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(issuer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalIssuer);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x000F67C0 File Offset: 0x000F49C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208696, XrefRangeEnd = 208713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Claim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(issuer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalIssuer);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subject);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyKey);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_String_ClaimsIdentity_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x000F6890 File Offset: 0x000F4A90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208742, RefRangeEnd = 208743, XrefRangeStart = 208713, XrefRangeEnd = 208742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Claim(Claim other, ClaimsIdentity subject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Claim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr__ctor_Protected_Void_Claim_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x000F68F0 File Offset: 0x000F4AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208743, XrefRangeEnd = 208746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializedMethod(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x060030DE RID: 12510 RVA: 0x000F6938 File Offset: 0x000F4B38
		public unsafe IDictionary<string, string> Properties
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 208755, RefRangeEnd = 208756, XrefRangeStart = 208746, XrefRangeEnd = 208755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x060030DF RID: 12511 RVA: 0x000F6978 File Offset: 0x000F4B78
		// (set) Token: 0x060030E0 RID: 12512 RVA: 0x000F69B8 File Offset: 0x000F4BB8
		public unsafe ClaimsIdentity Subject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_get_Subject_Public_get_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr3) : null;
			}
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 13543, RefRangeEnd = 13569, XrefRangeStart = 13543, XrefRangeEnd = 13569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_set_Subject_Internal_set_Void_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x060030E1 RID: 12513 RVA: 0x000F69FC File Offset: 0x000F4BFC
		public unsafe string Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_get_Type_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x060030E2 RID: 12514 RVA: 0x000F6A34 File Offset: 0x000F4C34
		public unsafe string Value
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Claim.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x000F6A6C File Offset: 0x000F4C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208756, XrefRangeEnd = 208760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Claim Clone(ClaimsIdentity identity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Claim.NativeMethodInfoPtr_Clone_Public_Virtual_New_Claim_ClaimsIdentity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Claim>(intPtr3) : null;
			}
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x000F6AC8 File Offset: 0x000F4CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208760, XrefRangeEnd = 208771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Claim.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x00010FCC File Offset: 0x0000F1CC
		public Claim(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x000F6B0C File Offset: 0x000F4D0C
		// (set) Token: 0x060030E7 RID: 12519 RVA: 0x00010FD5 File Offset: 0x0000F1D5
		public unsafe string m_issuer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_issuer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_issuer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x060030E8 RID: 12520 RVA: 0x000F6B34 File Offset: 0x000F4D34
		// (set) Token: 0x060030E9 RID: 12521 RVA: 0x00010FF4 File Offset: 0x0000F1F4
		public unsafe string m_originalIssuer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_originalIssuer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_originalIssuer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x060030EA RID: 12522 RVA: 0x000F6B5C File Offset: 0x000F4D5C
		// (set) Token: 0x060030EB RID: 12523 RVA: 0x00011013 File Offset: 0x0000F213
		public unsafe string m_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x060030EC RID: 12524 RVA: 0x000F6B84 File Offset: 0x000F4D84
		// (set) Token: 0x060030ED RID: 12525 RVA: 0x00011032 File Offset: 0x0000F232
		public unsafe string m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x000F6BAC File Offset: 0x000F4DAC
		// (set) Token: 0x060030EF RID: 12527 RVA: 0x00011051 File Offset: 0x0000F251
		public unsafe string m_valueType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_valueType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_valueType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x000F6BD4 File Offset: 0x000F4DD4
		// (set) Token: 0x060030F1 RID: 12529 RVA: 0x00011070 File Offset: 0x0000F270
		public unsafe Il2CppStructArray<byte> m_userSerializationData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_userSerializationData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_userSerializationData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x000F6C04 File Offset: 0x000F4E04
		// (set) Token: 0x060030F3 RID: 12531 RVA: 0x0001108F File Offset: 0x0000F28F
		public unsafe Dictionary<string, string> m_properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x000F6C34 File Offset: 0x000F4E34
		// (set) Token: 0x060030F5 RID: 12533 RVA: 0x000110AE File Offset: 0x0000F2AE
		public unsafe Object m_propertyLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_propertyLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_propertyLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x000F6C64 File Offset: 0x000F4E64
		// (set) Token: 0x060030F7 RID: 12535 RVA: 0x000110CD File Offset: 0x0000F2CD
		public unsafe ClaimsIdentity m_subject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_subject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Claim.NativeFieldInfoPtr_m_subject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A0D RID: 10765
		private static readonly IntPtr NativeFieldInfoPtr_m_issuer;

		// Token: 0x04002A0E RID: 10766
		private static readonly IntPtr NativeFieldInfoPtr_m_originalIssuer;

		// Token: 0x04002A0F RID: 10767
		private static readonly IntPtr NativeFieldInfoPtr_m_type;

		// Token: 0x04002A10 RID: 10768
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04002A11 RID: 10769
		private static readonly IntPtr NativeFieldInfoPtr_m_valueType;

		// Token: 0x04002A12 RID: 10770
		private static readonly IntPtr NativeFieldInfoPtr_m_userSerializationData;

		// Token: 0x04002A13 RID: 10771
		private static readonly IntPtr NativeFieldInfoPtr_m_properties;

		// Token: 0x04002A14 RID: 10772
		private static readonly IntPtr NativeFieldInfoPtr_m_propertyLock;

		// Token: 0x04002A15 RID: 10773
		private static readonly IntPtr NativeFieldInfoPtr_m_subject;

		// Token: 0x04002A16 RID: 10774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_ClaimsIdentity_0;

		// Token: 0x04002A17 RID: 10775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_String_ClaimsIdentity_String_String_0;

		// Token: 0x04002A18 RID: 10776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Claim_ClaimsIdentity_0;

		// Token: 0x04002A19 RID: 10777
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0;

		// Token: 0x04002A1A RID: 10778
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_String_0;

		// Token: 0x04002A1B RID: 10779
		private static readonly IntPtr NativeMethodInfoPtr_get_Subject_Public_get_ClaimsIdentity_0;

		// Token: 0x04002A1C RID: 10780
		private static readonly IntPtr NativeMethodInfoPtr_set_Subject_Internal_set_Void_ClaimsIdentity_0;

		// Token: 0x04002A1D RID: 10781
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_String_0;

		// Token: 0x04002A1E RID: 10782
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x04002A1F RID: 10783
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Claim_ClaimsIdentity_0;

		// Token: 0x04002A20 RID: 10784
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
