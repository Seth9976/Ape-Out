using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000011 RID: 17
	public class CallbackIdentityAttribute : Attribute
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x0000FFB8 File Offset: 0x0000E1B8
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackIdentityAttribute()
		{
			Il2CppClassPointerStore<CallbackIdentityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CallbackIdentityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackIdentityAttribute>.NativeClassPtr);
			CallbackIdentityAttribute.NativeFieldInfoPtr__Identity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackIdentityAttribute>.NativeClassPtr, "<Identity>k__BackingField");
			CallbackIdentityAttribute.NativeMethodInfoPtr_get_Identity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackIdentityAttribute>.NativeClassPtr, 100663384);
			CallbackIdentityAttribute.NativeMethodInfoPtr_set_Identity_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackIdentityAttribute>.NativeClassPtr, 100663385);
			CallbackIdentityAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackIdentityAttribute>.NativeClassPtr, 100663386);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00010038 File Offset: 0x0000E238
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00010074 File Offset: 0x0000E274
		public unsafe int Identity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackIdentityAttribute.NativeMethodInfoPtr_get_Identity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackIdentityAttribute.NativeMethodInfoPtr_set_Identity_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000100B4 File Offset: 0x0000E2B4
		[CallerCount(0)]
		public unsafe CallbackIdentityAttribute(int callbackNum)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackIdentityAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref callbackNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackIdentityAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000024ED File Offset: 0x000006ED
		public CallbackIdentityAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000100FC File Offset: 0x0000E2FC
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000024F6 File Offset: 0x000006F6
		public unsafe int _Identity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackIdentityAttribute.NativeFieldInfoPtr__Identity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackIdentityAttribute.NativeFieldInfoPtr__Identity_k__BackingField)) = value;
			}
		}

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr__Identity_k__BackingField;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_get_Identity_Public_get_Int32_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_set_Identity_Public_set_Void_Int32_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
