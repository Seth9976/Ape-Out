using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200002D RID: 45
	public class UriBuilder : Object
	{
		// Token: 0x06000259 RID: 601 RVA: 0x00019880 File Offset: 0x00017A80
		// Note: this type is marked as 'beforefieldinit'.
		static UriBuilder()
		{
			Il2CppClassPointerStore<UriBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "UriBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr);
			UriBuilder.NativeFieldInfoPtr__changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_changed");
			UriBuilder.NativeFieldInfoPtr__fragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_fragment");
			UriBuilder.NativeFieldInfoPtr__host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_host");
			UriBuilder.NativeFieldInfoPtr__password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_password");
			UriBuilder.NativeFieldInfoPtr__path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_path");
			UriBuilder.NativeFieldInfoPtr__port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_port");
			UriBuilder.NativeFieldInfoPtr__query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_query");
			UriBuilder.NativeFieldInfoPtr__scheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_scheme");
			UriBuilder.NativeFieldInfoPtr__schemeDelimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_schemeDelimiter");
			UriBuilder.NativeFieldInfoPtr__uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_uri");
			UriBuilder.NativeFieldInfoPtr__username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_username");
			UriBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100663763);
			UriBuilder.NativeMethodInfoPtr_set_Host_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100663764);
			UriBuilder.NativeMethodInfoPtr_set_Path_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100663765);
			UriBuilder.NativeMethodInfoPtr_set_Scheme_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100663766);
			UriBuilder.NativeMethodInfoPtr_get_Uri_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100663767);
			UriBuilder.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100663768);
			UriBuilder.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100663769);
			UriBuilder.NativeMethodInfoPtr_SetFieldsFromUri_Private_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100663770);
			UriBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100663771);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00019A40 File Offset: 0x00017C40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366891, RefRangeEnd = 366892, XrefRangeStart = 366876, XrefRangeEnd = 366891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000C5 RID: 197
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00019A7C File Offset: 0x00017C7C
		public unsafe string Host
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366892, XrefRangeEnd = 366901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriBuilder.NativeMethodInfoPtr_set_Host_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00019AC0 File Offset: 0x00017CC0
		public unsafe string Path
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 366915, RefRangeEnd = 366916, XrefRangeStart = 366901, XrefRangeEnd = 366915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriBuilder.NativeMethodInfoPtr_set_Path_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00019B04 File Offset: 0x00017D04
		public unsafe string Scheme
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 366925, RefRangeEnd = 366926, XrefRangeStart = 366916, XrefRangeEnd = 366925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriBuilder.NativeMethodInfoPtr_set_Scheme_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00019B48 File Offset: 0x00017D48
		public unsafe Uri Uri
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366931, RefRangeEnd = 366934, XrefRangeStart = 366926, XrefRangeEnd = 366931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriBuilder.NativeMethodInfoPtr_get_Uri_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00019B88 File Offset: 0x00017D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366934, XrefRangeEnd = 366935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object rparam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rparam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriBuilder.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00019BE0 File Offset: 0x00017DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366935, XrefRangeEnd = 366937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriBuilder.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00019C28 File Offset: 0x00017E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366958, RefRangeEnd = 366959, XrefRangeStart = 366937, XrefRangeEnd = 366958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFieldsFromUri(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriBuilder.NativeMethodInfoPtr_SetFieldsFromUri_Private_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00019C6C File Offset: 0x00017E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366959, XrefRangeEnd = 367049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002E38 File Offset: 0x00001038
		public UriBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00019CB0 File Offset: 0x00017EB0
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00002E41 File Offset: 0x00001041
		public unsafe bool _changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__changed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__changed)) = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00019CD8 File Offset: 0x00017ED8
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002E5C File Offset: 0x0000105C
		public unsafe string _fragment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__fragment);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__fragment), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00019D00 File Offset: 0x00017F00
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00002E7B File Offset: 0x0000107B
		public unsafe string _host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__host);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__host), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00019D28 File Offset: 0x00017F28
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00002E9A File Offset: 0x0000109A
		public unsafe string _password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00019D50 File Offset: 0x00017F50
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00002EB9 File Offset: 0x000010B9
		public unsafe string _path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00019D78 File Offset: 0x00017F78
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00002ED8 File Offset: 0x000010D8
		public unsafe int _port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__port)) = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00019DA0 File Offset: 0x00017FA0
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00002EF3 File Offset: 0x000010F3
		public unsafe string _query
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__query);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__query), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00019DC8 File Offset: 0x00017FC8
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00002F12 File Offset: 0x00001112
		public unsafe string _scheme
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__scheme);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__scheme), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00019DF0 File Offset: 0x00017FF0
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00002F31 File Offset: 0x00001131
		public unsafe string _schemeDelimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__schemeDelimiter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__schemeDelimiter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00019E18 File Offset: 0x00018018
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00002F50 File Offset: 0x00001150
		public unsafe Uri _uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00019E48 File Offset: 0x00018048
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00002F6F File Offset: 0x0000116F
		public unsafe string _username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr__changed;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr__fragment;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeFieldInfoPtr__host;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeFieldInfoPtr__password;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeFieldInfoPtr__path;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeFieldInfoPtr__port;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeFieldInfoPtr__query;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeFieldInfoPtr__scheme;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeFieldInfoPtr__schemeDelimiter;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeFieldInfoPtr__uri;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr__username;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_set_Host_Public_set_Void_String_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_set_Path_Public_set_Void_String_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_set_Scheme_Public_set_Void_String_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_get_Uri_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_SetFieldsFromUri_Private_Void_Uri_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
