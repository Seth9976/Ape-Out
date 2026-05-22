using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000028 RID: 40
	public sealed class RewindableAllocator : ValueType
	{
		// Token: 0x06000122 RID: 290 RVA: 0x0000A310 File Offset: 0x00008510
		// Note: this type is marked as 'beforefieldinit'.
		static RewindableAllocator()
		{
			Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "RewindableAllocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr);
			RewindableAllocator.NativeFieldInfoPtr_m_spinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, "m_spinner");
			RewindableAllocator.NativeFieldInfoPtr_m_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, "m_handle");
			RewindableAllocator.NativeFieldInfoPtr_m_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, "m_block");
			RewindableAllocator.NativeFieldInfoPtr_m_best = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, "m_best");
			RewindableAllocator.NativeFieldInfoPtr_m_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, "m_last");
			RewindableAllocator.NativeFieldInfoPtr_m_used = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, "m_used");
			RewindableAllocator.NativeMethodInfoPtr_Rewind_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, 100663516);
			RewindableAllocator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, 100663517);
			RewindableAllocator.NativeMethodInfoPtr_Try_Public_Virtual_Final_New_Int32_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, 100663518);
			RewindableAllocator.NativeMethodInfoPtr_Try_Internal_Static_Int32_IntPtr_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, 100663519);
			RewindableAllocator.NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, 100663520);
			RewindableAllocator.NativeMethodInfoPtr_Method_Public_Static_Int32_IntPtr_byref_Block_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, 100663521);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000A430 File Offset: 0x00008630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440612, RefRangeEnd = 440613, XrefRangeStart = 440607, XrefRangeEnd = 440612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rewind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.NativeMethodInfoPtr_Rewind_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000A468 File Offset: 0x00008668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440613, XrefRangeEnd = 440649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000A4A0 File Offset: 0x000086A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 440655, RefRangeEnd = 440658, XrefRangeStart = 440649, XrefRangeEnd = 440655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Try(ref AllocatorManager.Block block)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &block;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.NativeMethodInfoPtr_Try_Public_Virtual_Final_New_Int32_byref_Block_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000A4F0 File Offset: 0x000086F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440658, XrefRangeEnd = 440670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Try(IntPtr state, ref AllocatorManager.Block block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.NativeMethodInfoPtr_Try_Internal_Static_Int32_IntPtr_byref_Block_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000A53C File Offset: 0x0000873C
		public unsafe AllocatorManager.AllocatorHandle Handle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_AllocatorHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000A580 File Offset: 0x00008780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440670, XrefRangeEnd = 440671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Method_Public_Static_Int32_IntPtr_byref_Block_PDM_0(IntPtr state, ref AllocatorManager.Block block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.NativeMethodInfoPtr_Method_Public_Static_Int32_IntPtr_byref_Block_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000266B File Offset: 0x0000086B
		public RewindableAllocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002674 File Offset: 0x00000874
		public RewindableAllocator()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr))
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000A5CC File Offset: 0x000087CC
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00002686 File Offset: 0x00000886
		public unsafe Spinner m_spinner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewindableAllocator.NativeFieldInfoPtr_m_spinner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewindableAllocator.NativeFieldInfoPtr_m_spinner)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000A5F4 File Offset: 0x000087F4
		// (set) Token: 0x0600012E RID: 302 RVA: 0x000026A1 File Offset: 0x000008A1
		public unsafe AllocatorManager.AllocatorHandle m_handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewindableAllocator.NativeFieldInfoPtr_m_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewindableAllocator.NativeFieldInfoPtr_m_handle)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000A61C File Offset: 0x0000881C
		// (set) Token: 0x06000130 RID: 304 RVA: 0x000026BC File Offset: 0x000008BC
		public UnmanagedArray<RewindableAllocator.MemoryBlock> m_block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewindableAllocator.NativeFieldInfoPtr_m_block);
				return new UnmanagedArray<RewindableAllocator.MemoryBlock>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnmanagedArray<RewindableAllocator.MemoryBlock>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewindableAllocator.NativeFieldInfoPtr_m_block), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnmanagedArray<RewindableAllocator.MemoryBlock>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000A64C File Offset: 0x0000884C
		// (set) Token: 0x06000132 RID: 306 RVA: 0x000026EA File Offset: 0x000008EA
		public unsafe int m_best
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewindableAllocator.NativeFieldInfoPtr_m_best);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewindableAllocator.NativeFieldInfoPtr_m_best)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000A674 File Offset: 0x00008874
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00002705 File Offset: 0x00000905
		public unsafe int m_last
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewindableAllocator.NativeFieldInfoPtr_m_last);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewindableAllocator.NativeFieldInfoPtr_m_last)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000A69C File Offset: 0x0000889C
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002720 File Offset: 0x00000920
		public unsafe int m_used
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewindableAllocator.NativeFieldInfoPtr_m_used);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewindableAllocator.NativeFieldInfoPtr_m_used)) = value;
			}
		}

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeFieldInfoPtr_m_spinner;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeFieldInfoPtr_m_handle;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeFieldInfoPtr_m_block;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeFieldInfoPtr_m_best;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeFieldInfoPtr_m_last;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeFieldInfoPtr_m_used;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_Rewind_Public_Void_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_Try_Public_Virtual_Final_New_Int32_byref_Block_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_Try_Internal_Static_Int32_IntPtr_byref_Block_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_AllocatorHandle_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Int32_IntPtr_byref_Block_PDM_0;

		// Token: 0x0200004E RID: 78
		[StructLayout(2)]
		public struct MemoryBlock
		{
			// Token: 0x060002D1 RID: 721 RVA: 0x00010D48 File Offset: 0x0000EF48
			// Note: this type is marked as 'beforefieldinit'.
			static MemoryBlock()
			{
				Il2CppClassPointerStore<RewindableAllocator.MemoryBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, "MemoryBlock");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewindableAllocator.MemoryBlock>.NativeClassPtr);
				RewindableAllocator.MemoryBlock.NativeFieldInfoPtr_m_pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewindableAllocator.MemoryBlock>.NativeClassPtr, "m_pointer");
				RewindableAllocator.MemoryBlock.NativeFieldInfoPtr_m_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewindableAllocator.MemoryBlock>.NativeClassPtr, "m_bytes");
				RewindableAllocator.MemoryBlock.NativeFieldInfoPtr_m_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewindableAllocator.MemoryBlock>.NativeClassPtr, "m_current");
				RewindableAllocator.MemoryBlock.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator.MemoryBlock>.NativeClassPtr, 100663522);
				RewindableAllocator.MemoryBlock.NativeMethodInfoPtr_Rewind_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator.MemoryBlock>.NativeClassPtr, 100663523);
				RewindableAllocator.MemoryBlock.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator.MemoryBlock>.NativeClassPtr, 100663524);
				RewindableAllocator.MemoryBlock.NativeMethodInfoPtr_TryAllocate_Public_Int32_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator.MemoryBlock>.NativeClassPtr, 100663525);
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x00010E00 File Offset: 0x0000F000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440538, XrefRangeEnd = 440539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MemoryBlock(long bytes)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref bytes;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.MemoryBlock.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x00010E34 File Offset: 0x0000F034
			[CallerCount(0)]
			public unsafe void Rewind()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.MemoryBlock.NativeMethodInfoPtr_Rewind_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D4 RID: 724 RVA: 0x00010E5C File Offset: 0x0000F05C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 440541, RefRangeEnd = 440542, XrefRangeStart = 440539, XrefRangeEnd = 440541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.MemoryBlock.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D5 RID: 725 RVA: 0x00010E84 File Offset: 0x0000F084
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 440542, RefRangeEnd = 440543, XrefRangeStart = 440542, XrefRangeEnd = 440542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int TryAllocate(ref AllocatorManager.Block block)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &block;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.MemoryBlock.NativeMethodInfoPtr_TryAllocate_Public_Int32_byref_Block_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x0000348C File Offset: 0x0000168C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RewindableAllocator.MemoryBlock>.NativeClassPtr, ref this));
			}

			// Token: 0x0400051F RID: 1311
			private static readonly IntPtr NativeFieldInfoPtr_m_pointer;

			// Token: 0x04000520 RID: 1312
			private static readonly IntPtr NativeFieldInfoPtr_m_bytes;

			// Token: 0x04000521 RID: 1313
			private static readonly IntPtr NativeFieldInfoPtr_m_current;

			// Token: 0x04000522 RID: 1314
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

			// Token: 0x04000523 RID: 1315
			private static readonly IntPtr NativeMethodInfoPtr_Rewind_Public_Void_0;

			// Token: 0x04000524 RID: 1316
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000525 RID: 1317
			private static readonly IntPtr NativeMethodInfoPtr_TryAllocate_Public_Int32_byref_Block_0;

			// Token: 0x04000526 RID: 1318
			[FieldOffset(0)]
			public IntPtr m_pointer;

			// Token: 0x04000527 RID: 1319
			[FieldOffset(8)]
			public long m_bytes;

			// Token: 0x04000528 RID: 1320
			[FieldOffset(16)]
			public long m_current;
		}

		// Token: 0x0200004F RID: 79
		[ObfuscatedName("Unity.Collections.RewindableAllocator+Try_000006A4$PostfixBurstDelegate")]
		public sealed class MulticastDelegateNPublicSealedInObInUnique : MulticastDelegate
		{
			// Token: 0x060002D7 RID: 727 RVA: 0x00010EC4 File Offset: 0x0000F0C4
			// Note: this type is marked as 'beforefieldinit'.
			static MulticastDelegateNPublicSealedInObInUnique()
			{
				Il2CppClassPointerStore<RewindableAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, "Try_000006A4$PostfixBurstDelegate");
				RewindableAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr, 100663526);
				RewindableAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr, 100663527);
				RewindableAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Block_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr, 100663528);
				RewindableAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr, 100663529);
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x00010F38 File Offset: 0x0000F138
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulticastDelegateNPublicSealedInObInUnique(Object A_1, IntPtr A_2)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewindableAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D9 RID: 729 RVA: 0x00010F94 File Offset: 0x0000F194
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 439745, RefRangeEnd = 439748, XrefRangeStart = 439745, XrefRangeEnd = 439748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Invoke(IntPtr state, ref AllocatorManager.Block block)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_byref_Block_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060002DA RID: 730 RVA: 0x00010FEC File Offset: 0x0000F1EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440543, XrefRangeEnd = 440550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr state, ref AllocatorManager.Block block, AsyncCallback A_3, Object A_4)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Block_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060002DB RID: 731 RVA: 0x0001106C File Offset: 0x0000F26C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002DC RID: 732 RVA: 0x0000349E File Offset: 0x0000169E
			public MulticastDelegateNPublicSealedInObInUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000529 RID: 1321
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400052A RID: 1322
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_byref_Block_0;

			// Token: 0x0400052B RID: 1323
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Block_AsyncCallback_Object_0;

			// Token: 0x0400052C RID: 1324
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}

		// Token: 0x02000050 RID: 80
		[ObfuscatedName("Unity.Collections.RewindableAllocator+Try_000006A4$BurstDirectCall")]
		public static class ObjectNPrivateAbstractSealedInPoUnique : Object
		{
			// Token: 0x060002DD RID: 733 RVA: 0x000110BC File Offset: 0x0000F2BC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectNPrivateAbstractSealedInPoUnique()
			{
				Il2CppClassPointerStore<RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewindableAllocator>.NativeClassPtr, "Try_000006A4$BurstDirectCall");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr);
				RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, "Pointer");
				RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663530);
				RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663531);
				RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663532);
				RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663533);
				RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Invoke_Public_Static_Int32_IntPtr_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663535);
			}

			// Token: 0x060002DE RID: 734 RVA: 0x00011160 File Offset: 0x0000F360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440550, XrefRangeEnd = 440566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &A_0;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002DF RID: 735 RVA: 0x00011194 File Offset: 0x0000F394
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 440586, RefRangeEnd = 440589, XrefRangeStart = 440566, XrefRangeEnd = 440586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IntPtr GetFunctionPointer()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060002E0 RID: 736 RVA: 0x000111C4 File Offset: 0x0000F3C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440589, XrefRangeEnd = 440594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Constructor()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002E1 RID: 737 RVA: 0x000111EC File Offset: 0x0000F3EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440594, XrefRangeEnd = 440598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Initialize()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x00011214 File Offset: 0x0000F414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440598, XrefRangeEnd = 440607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int Invoke(IntPtr state, ref AllocatorManager.Block block)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Invoke_Public_Static_Int32_IntPtr_byref_Block_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x000034A7 File Offset: 0x000016A7
			public ObjectNPrivateAbstractSealedInPoUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x060002E4 RID: 740 RVA: 0x00011260 File Offset: 0x0000F460
			// (set) Token: 0x060002E5 RID: 741 RVA: 0x000034B0 File Offset: 0x000016B0
			public unsafe static IntPtr Pointer
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeFieldInfoPtr_Pointer, (void*)(&intPtr));
					return intPtr;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RewindableAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeFieldInfoPtr_Pointer, (void*)(&value));
				}
			}

			// Token: 0x0400052D RID: 1325
			private static readonly IntPtr NativeFieldInfoPtr_Pointer;

			// Token: 0x0400052E RID: 1326
			private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

			// Token: 0x0400052F RID: 1327
			private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

			// Token: 0x04000530 RID: 1328
			private static readonly IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;

			// Token: 0x04000531 RID: 1329
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

			// Token: 0x04000532 RID: 1330
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Int32_IntPtr_byref_Block_0;
		}
	}
}
