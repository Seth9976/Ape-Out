using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000160 RID: 352
	[StructLayout(2)]
	public struct RenderTargetIdentifier
	{
		// Token: 0x060019D9 RID: 6617 RVA: 0x00062F84 File Offset: 0x00061184
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTargetIdentifier()
		{
			Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderTargetIdentifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr);
			RenderTargetIdentifier.NativeFieldInfoPtr_AllDepthSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "AllDepthSlices");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_Type");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_NameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_NameID");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_InstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_InstanceID");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_BufferPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_BufferPointer");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_MipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_MipLevel");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_CubeFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_CubeFace");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_DepthSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_DepthSlice");
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665705);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665706);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665707);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665708);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665709);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665710);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665711);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665712);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665713);
			RenderTargetIdentifier.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665714);
			RenderTargetIdentifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665715);
			RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665716);
			RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665717);
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x00063158 File Offset: 0x00061358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502363, XrefRangeEnd = 502364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(BuiltinRenderTextureType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x0006318C File Offset: 0x0006138C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502364, XrefRangeEnd = 502365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(int nameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x000631C0 File Offset: 0x000613C0
		[CallerCount(0)]
		public unsafe RenderTargetIdentifier(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderTargetIdentifier;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubeFace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0006321C File Offset: 0x0006141C
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 502387, RefRangeEnd = 502430, XrefRangeStart = 502365, XrefRangeEnd = 502387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(Texture tex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Texture_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00063254 File Offset: 0x00061454
		[CallerCount(0)]
		public unsafe RenderTargetIdentifier(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buf;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubeFace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_RenderBuffer_Int32_CubemapFace_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x000632B0 File Offset: 0x000614B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 502431, RefRangeEnd = 502435, XrefRangeStart = 502430, XrefRangeEnd = 502431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTargetIdentifier(BuiltinRenderTextureType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x000632F0 File Offset: 0x000614F0
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 502436, RefRangeEnd = 502463, XrefRangeStart = 502435, XrefRangeEnd = 502436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTargetIdentifier(int nameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00063330 File Offset: 0x00061530
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 502464, RefRangeEnd = 502469, XrefRangeStart = 502463, XrefRangeEnd = 502464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTargetIdentifier(Texture tex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00063374 File Offset: 0x00061574
		[CallerCount(0)]
		public unsafe static implicit operator RenderTargetIdentifier(RenderBuffer buf)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buf;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_RenderBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x000633B4 File Offset: 0x000615B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502469, XrefRangeEnd = 502522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x000633E0 File Offset: 0x000615E0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00063410 File Offset: 0x00061610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 502522, RefRangeEnd = 502523, XrefRangeStart = 502522, XrefRangeEnd = 502522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RenderTargetIdentifier rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00063450 File Offset: 0x00061650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502523, XrefRangeEnd = 502526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x0000D8CB File Offset: 0x0000BACB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, ref this));
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x00063494 File Offset: 0x00061694
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x0000D8DD File Offset: 0x0000BADD
		public unsafe static int AllDepthSlices
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RenderTargetIdentifier.NativeFieldInfoPtr_AllDepthSlices, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderTargetIdentifier.NativeFieldInfoPtr_AllDepthSlices, (void*)(&value));
			}
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x000634B0 File Offset: 0x000616B0
		public static implicit operator RenderTargetIdentifier(string name)
		{
			return new RenderTargetIdentifier(name);
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x000634C8 File Offset: 0x000616C8
		public static bool operator ==(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x000634E4 File Offset: 0x000616E4
		public static bool operator !=(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
		{
			return !lhs.Equals(rhs);
		}

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeFieldInfoPtr_AllDepthSlices;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeFieldInfoPtr_m_NameID;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceID;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferPointer;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeFieldInfoPtr_m_MipLevel;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeFieldInfoPtr_m_CubeFace;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthSlice;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_0;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderBuffer_Int32_CubemapFace_Int32_0;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_RenderBuffer_0;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400146F RID: 5231
		[FieldOffset(0)]
		public BuiltinRenderTextureType m_Type;

		// Token: 0x04001470 RID: 5232
		[FieldOffset(4)]
		public int m_NameID;

		// Token: 0x04001471 RID: 5233
		[FieldOffset(8)]
		public int m_InstanceID;

		// Token: 0x04001472 RID: 5234
		[FieldOffset(16)]
		public IntPtr m_BufferPointer;

		// Token: 0x04001473 RID: 5235
		[FieldOffset(24)]
		public int m_MipLevel;

		// Token: 0x04001474 RID: 5236
		[FieldOffset(28)]
		public CubemapFace m_CubeFace;

		// Token: 0x04001475 RID: 5237
		[FieldOffset(32)]
		public int m_DepthSlice;
	}
}
