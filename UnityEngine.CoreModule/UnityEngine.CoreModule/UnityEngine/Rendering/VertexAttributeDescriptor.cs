using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200015F RID: 351
	[StructLayout(2)]
	public struct VertexAttributeDescriptor
	{
		// Token: 0x060019C8 RID: 6600 RVA: 0x00062AF8 File Offset: 0x00060CF8
		// Note: this type is marked as 'beforefieldinit'.
		static VertexAttributeDescriptor()
		{
			Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "VertexAttributeDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr);
			VertexAttributeDescriptor.NativeFieldInfoPtr__attribute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<attribute>k__BackingField");
			VertexAttributeDescriptor.NativeFieldInfoPtr__format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<format>k__BackingField");
			VertexAttributeDescriptor.NativeFieldInfoPtr__dimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<dimension>k__BackingField");
			VertexAttributeDescriptor.NativeFieldInfoPtr__stream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<stream>k__BackingField");
			VertexAttributeDescriptor.NativeMethodInfoPtr_get_attribute_Public_get_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100665692);
			VertexAttributeDescriptor.NativeMethodInfoPtr_set_attribute_Public_set_Void_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100665693);
			VertexAttributeDescriptor.NativeMethodInfoPtr_get_format_Public_get_VertexAttributeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100665694);
			VertexAttributeDescriptor.NativeMethodInfoPtr_set_format_Public_set_Void_VertexAttributeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100665695);
			VertexAttributeDescriptor.NativeMethodInfoPtr_get_dimension_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100665696);
			VertexAttributeDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100665697);
			VertexAttributeDescriptor.NativeMethodInfoPtr_get_stream_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100665698);
			VertexAttributeDescriptor.NativeMethodInfoPtr_set_stream_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100665699);
			VertexAttributeDescriptor.NativeMethodInfoPtr__ctor_Public_Void_VertexAttribute_VertexAttributeFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100665700);
			VertexAttributeDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100665701);
			VertexAttributeDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100665702);
			VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100665703);
			VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100665704);
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x00062C7C File Offset: 0x00060E7C
		// (set) Token: 0x060019CA RID: 6602 RVA: 0x00062CAC File Offset: 0x00060EAC
		public unsafe VertexAttribute attribute
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_attribute_Public_get_VertexAttribute_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_attribute_Public_set_Void_VertexAttribute_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x00062CE0 File Offset: 0x00060EE0
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x00062D10 File Offset: 0x00060F10
		public unsafe VertexAttributeFormat format
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_format_Public_get_VertexAttributeFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_format_Public_set_Void_VertexAttributeFormat_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x00062D44 File Offset: 0x00060F44
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x00062D74 File Offset: 0x00060F74
		public unsafe int dimension
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_dimension_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x00062DA8 File Offset: 0x00060FA8
		// (set) Token: 0x060019D0 RID: 6608 RVA: 0x00062DD8 File Offset: 0x00060FD8
		public unsafe int stream
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_stream_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_stream_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00062E0C File Offset: 0x0006100C
		[CallerCount(0)]
		public unsafe VertexAttributeDescriptor(VertexAttribute attribute = VertexAttribute.Position, VertexAttributeFormat format = VertexAttributeFormat.Float32, int dimension = 3, int stream = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attribute;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stream;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr__ctor_Public_Void_VertexAttribute_VertexAttributeFormat_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00062E68 File Offset: 0x00061068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502327, XrefRangeEnd = 502361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00062E94 File Offset: 0x00061094
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00062EC4 File Offset: 0x000610C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502361, XrefRangeEnd = 502363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00062F08 File Offset: 0x00061108
		[CallerCount(0)]
		public unsafe bool Equals(VertexAttributeDescriptor other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexAttributeDescriptor_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x0000D8B9 File Offset: 0x0000BAB9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, ref this));
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00062F48 File Offset: 0x00061148
		public static bool operator ==(VertexAttributeDescriptor lhs, VertexAttributeDescriptor rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00062F64 File Offset: 0x00061164
		public static bool operator !=(VertexAttributeDescriptor lhs, VertexAttributeDescriptor rhs)
		{
			return !lhs.Equals(rhs);
		}

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeFieldInfoPtr__attribute_k__BackingField;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeFieldInfoPtr__format_k__BackingField;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeFieldInfoPtr__dimension_k__BackingField;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeFieldInfoPtr__stream_k__BackingField;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeMethodInfoPtr_get_attribute_Public_get_VertexAttribute_0;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeMethodInfoPtr_set_attribute_Public_set_Void_VertexAttribute_0;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeMethodInfoPtr_get_format_Public_get_VertexAttributeFormat_0;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr_set_format_Public_set_Void_VertexAttributeFormat_0;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_get_dimension_Public_get_Int32_0;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr_set_dimension_Public_set_Void_Int32_0;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeMethodInfoPtr_get_stream_Public_get_Int32_0;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeMethodInfoPtr_set_stream_Public_set_Void_Int32_0;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VertexAttribute_VertexAttributeFormat_Int32_Int32_0;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexAttributeDescriptor_0;

		// Token: 0x04001456 RID: 5206
		[FieldOffset(0)]
		public VertexAttribute _attribute_k__BackingField;

		// Token: 0x04001457 RID: 5207
		[FieldOffset(4)]
		public VertexAttributeFormat _format_k__BackingField;

		// Token: 0x04001458 RID: 5208
		[FieldOffset(8)]
		public int _dimension_k__BackingField;

		// Token: 0x04001459 RID: 5209
		[FieldOffset(12)]
		public int _stream_k__BackingField;
	}
}
