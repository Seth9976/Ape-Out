using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200034D RID: 845
	[Serializable]
	public sealed class StreamingContext : ValueType
	{
		// Token: 0x06003744 RID: 14148 RVA: 0x0010E430 File Offset: 0x0010C630
		// Note: this type is marked as 'beforefieldinit'.
		static StreamingContext()
		{
			Il2CppClassPointerStore<StreamingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "StreamingContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr);
			StreamingContext.NativeFieldInfoPtr_m_additionalContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, "m_additionalContext");
			StreamingContext.NativeFieldInfoPtr_m_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, "m_state");
			StreamingContext.NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671859);
			StreamingContext.NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671860);
			StreamingContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671861);
			StreamingContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671862);
			StreamingContext.NativeMethodInfoPtr_get_State_Public_get_StreamingContextStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671863);
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x0010E4EC File Offset: 0x0010C6EC
		[CallerCount(0)]
		public unsafe StreamingContext(StreamingContextStates state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x0010E538 File Offset: 0x0010C738
		[CallerCount(0)]
		public unsafe StreamingContext(StreamingContextStates state, Object additional)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additional);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x0010E598 File Offset: 0x0010C798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215671, XrefRangeEnd = 215673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x0010E5EC File Offset: 0x0010C7EC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06003749 RID: 14153 RVA: 0x0010E630 File Offset: 0x0010C830
		public unsafe StreamingContextStates State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr_get_State_Public_get_StreamingContextStates_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x00013AC5 File Offset: 0x00011CC5
		public StreamingContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x00013ACE File Offset: 0x00011CCE
		public StreamingContext()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr))
		{
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x0600374C RID: 14156 RVA: 0x0010E674 File Offset: 0x0010C874
		// (set) Token: 0x0600374D RID: 14157 RVA: 0x00013AE0 File Offset: 0x00011CE0
		public unsafe Object m_additionalContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamingContext.NativeFieldInfoPtr_m_additionalContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamingContext.NativeFieldInfoPtr_m_additionalContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x0600374E RID: 14158 RVA: 0x0010E6A4 File Offset: 0x0010C8A4
		// (set) Token: 0x0600374F RID: 14159 RVA: 0x00013AFF File Offset: 0x00011CFF
		public unsafe StreamingContextStates m_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamingContext.NativeFieldInfoPtr_m_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamingContext.NativeFieldInfoPtr_m_state)) = value;
			}
		}

		// Token: 0x04002E7C RID: 11900
		private static readonly IntPtr NativeFieldInfoPtr_m_additionalContext;

		// Token: 0x04002E7D RID: 11901
		private static readonly IntPtr NativeFieldInfoPtr_m_state;

		// Token: 0x04002E7E RID: 11902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_0;

		// Token: 0x04002E7F RID: 11903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_Object_0;

		// Token: 0x04002E80 RID: 11904
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002E81 RID: 11905
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002E82 RID: 11906
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_StreamingContextStates_0;
	}
}
