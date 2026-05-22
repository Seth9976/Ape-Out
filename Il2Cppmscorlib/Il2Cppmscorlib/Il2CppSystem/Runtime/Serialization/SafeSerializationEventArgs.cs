using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200033C RID: 828
	public sealed class SafeSerializationEventArgs : EventArgs
	{
		// Token: 0x06003664 RID: 13924 RVA: 0x0010B028 File Offset: 0x00109228
		// Note: this type is marked as 'beforefieldinit'.
		static SafeSerializationEventArgs()
		{
			Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SafeSerializationEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr);
			SafeSerializationEventArgs.NativeFieldInfoPtr_m_streamingContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr, "m_streamingContext");
			SafeSerializationEventArgs.NativeFieldInfoPtr_m_serializedStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr, "m_serializedStates");
			SafeSerializationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr, 100671756);
			SafeSerializationEventArgs.NativeMethodInfoPtr_get_SerializedStates_Internal_get_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr, 100671757);
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x0010B0A8 File Offset: 0x001092A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214300, XrefRangeEnd = 214309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSerializationEventArgs(StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06003666 RID: 13926 RVA: 0x0010B0F8 File Offset: 0x001092F8
		public unsafe IList<Object> SerializedStates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationEventArgs.NativeMethodInfoPtr_get_SerializedStates_Internal_get_IList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x0001341B File Offset: 0x0001161B
		public SafeSerializationEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06003668 RID: 13928 RVA: 0x0010B138 File Offset: 0x00109338
		// (set) Token: 0x06003669 RID: 13929 RVA: 0x00013424 File Offset: 0x00011624
		public StreamingContext m_streamingContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationEventArgs.NativeFieldInfoPtr_m_streamingContext);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationEventArgs.NativeFieldInfoPtr_m_streamingContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x0600366A RID: 13930 RVA: 0x0010B168 File Offset: 0x00109368
		// (set) Token: 0x0600366B RID: 13931 RVA: 0x00013452 File Offset: 0x00011652
		public unsafe List<Object> m_serializedStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationEventArgs.NativeFieldInfoPtr_m_serializedStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationEventArgs.NativeFieldInfoPtr_m_serializedStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DEB RID: 11755
		private static readonly IntPtr NativeFieldInfoPtr_m_streamingContext;

		// Token: 0x04002DEC RID: 11756
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedStates;

		// Token: 0x04002DED RID: 11757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_StreamingContext_0;

		// Token: 0x04002DEE RID: 11758
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializedStates_Internal_get_IList_1_Object_0;
	}
}
