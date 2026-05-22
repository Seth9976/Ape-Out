using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x020000D8 RID: 216
	[Serializable]
	public class OperationCanceledException : SystemException
	{
		// Token: 0x06000E85 RID: 3717 RVA: 0x00065F48 File Offset: 0x00064148
		// Note: this type is marked as 'beforefieldinit'.
		static OperationCanceledException()
		{
			Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "OperationCanceledException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr);
			OperationCanceledException.NativeFieldInfoPtr__cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, "_cancellationToken");
			OperationCanceledException.NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665772);
			OperationCanceledException.NativeMethodInfoPtr_set_CancellationToken_Private_set_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665773);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665774);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665775);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665776);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665777);
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x00066004 File Offset: 0x00064204
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x0006603C File Offset: 0x0006423C
		public unsafe CancellationToken CancellationToken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 161221, RefRangeEnd = 161228, XrefRangeStart = 161221, XrefRangeEnd = 161221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr_set_CancellationToken_Private_set_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00066084 File Offset: 0x00064284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161231, RefRangeEnd = 161232, XrefRangeStart = 161228, XrefRangeEnd = 161231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x000660C0 File Offset: 0x000642C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161232, XrefRangeEnd = 161233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0006610C File Offset: 0x0006430C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161234, RefRangeEnd = 161236, XrefRangeStart = 161233, XrefRangeEnd = 161234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException(string message, CancellationToken token)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00066170 File Offset: 0x00064370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00005AD4 File Offset: 0x00003CD4
		public OperationCanceledException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x000661D4 File Offset: 0x000643D4
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x00005ADD File Offset: 0x00003CDD
		public CancellationToken _cancellationToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperationCanceledException.NativeFieldInfoPtr__cancellationToken);
				return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperationCanceledException.NativeFieldInfoPtr__cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeFieldInfoPtr__cancellationToken;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_set_CancellationToken_Private_set_Void_CancellationToken_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_CancellationToken_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
