using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200015B RID: 347
	[Serializable]
	public sealed class InputLayout : Object
	{
		// Token: 0x06002712 RID: 10002 RVA: 0x000C5E8C File Offset: 0x000C408C
		// Note: this type is marked as 'beforefieldinit'.
		static InputLayout()
		{
			Il2CppClassPointerStore<InputLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "InputLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputLayout>.NativeClassPtr);
			InputLayout.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputLayout>.NativeClassPtr, "_name");
			InputLayout.NativeFieldInfoPtr__descriptiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputLayout>.NativeClassPtr, "_descriptiveName");
			InputLayout.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputLayout>.NativeClassPtr, "_id");
			InputLayout.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputLayout>.NativeClassPtr, 100671683);
			InputLayout.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputLayout>.NativeClassPtr, 100671684);
			InputLayout.NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputLayout>.NativeClassPtr, 100671685);
			InputLayout.NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputLayout>.NativeClassPtr, 100671686);
			InputLayout.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputLayout>.NativeClassPtr, 100671687);
			InputLayout.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputLayout>.NativeClassPtr, 100671688);
			InputLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputLayout>.NativeClassPtr, 100671689);
			InputLayout.NativeMethodInfoPtr__ctor_Public_Void_InputLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputLayout>.NativeClassPtr, 100671690);
			InputLayout.NativeMethodInfoPtr_Clone_Public_InputLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputLayout>.NativeClassPtr, 100671691);
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06002713 RID: 10003 RVA: 0x000C5FAC File Offset: 0x000C41AC
		// (set) Token: 0x06002714 RID: 10004 RVA: 0x000C5FE4 File Offset: 0x000C41E4
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputLayout.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputLayout.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x000C6028 File Offset: 0x000C4228
		// (set) Token: 0x06002716 RID: 10006 RVA: 0x000C6060 File Offset: 0x000C4260
		public unsafe string descriptiveName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputLayout.NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputLayout.NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x000C60A4 File Offset: 0x000C42A4
		// (set) Token: 0x06002718 RID: 10008 RVA: 0x000C60E0 File Offset: 0x000C42E0
		public unsafe int id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputLayout.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputLayout.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x000C6120 File Offset: 0x000C4320
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x000C615C File Offset: 0x000C435C
		[CallerCount(0)]
		public unsafe InputLayout(InputLayout source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputLayout>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputLayout.NativeMethodInfoPtr__ctor_Public_Void_InputLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x000C61A8 File Offset: 0x000C43A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 295097, RefRangeEnd = 295101, XrefRangeStart = 295094, XrefRangeEnd = 295097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputLayout Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputLayout.NativeMethodInfoPtr_Clone_Public_InputLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputLayout>(intPtr3) : null;
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x0000F4C6 File Offset: 0x0000D6C6
		public InputLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x000C61E8 File Offset: 0x000C43E8
		// (set) Token: 0x0600271E RID: 10014 RVA: 0x0000F4CF File Offset: 0x0000D6CF
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputLayout.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputLayout.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600271F RID: 10015 RVA: 0x000C6210 File Offset: 0x000C4410
		// (set) Token: 0x06002720 RID: 10016 RVA: 0x0000F4EE File Offset: 0x0000D6EE
		public unsafe string _descriptiveName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputLayout.NativeFieldInfoPtr__descriptiveName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputLayout.NativeFieldInfoPtr__descriptiveName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06002721 RID: 10017 RVA: 0x000C6238 File Offset: 0x000C4438
		// (set) Token: 0x06002722 RID: 10018 RVA: 0x0000F50D File Offset: 0x0000D70D
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputLayout.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputLayout.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeFieldInfoPtr__descriptiveName;

		// Token: 0x0400200D RID: 8205
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x0400200E RID: 8206
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x0400200F RID: 8207
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Internal_set_Void_String_0;

		// Token: 0x04002010 RID: 8208
		private static readonly IntPtr NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0;

		// Token: 0x04002011 RID: 8209
		private static readonly IntPtr NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0;

		// Token: 0x04002012 RID: 8210
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04002013 RID: 8211
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0;

		// Token: 0x04002014 RID: 8212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002015 RID: 8213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputLayout_0;

		// Token: 0x04002016 RID: 8214
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_InputLayout_0;
	}
}
