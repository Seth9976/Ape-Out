using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000014 RID: 20
	public class CodePointIndexer : Object
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00025284 File Offset: 0x00023484
		// Note: this type is marked as 'beforefieldinit'.
		static CodePointIndexer()
		{
			Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "CodePointIndexer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr);
			CodePointIndexer.NativeFieldInfoPtr_ranges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "ranges");
			CodePointIndexer.NativeFieldInfoPtr_TotalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "TotalCount");
			CodePointIndexer.NativeFieldInfoPtr_defaultIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "defaultIndex");
			CodePointIndexer.NativeFieldInfoPtr_defaultCP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "defaultCP");
			CodePointIndexer.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, 100663410);
			CodePointIndexer.NativeMethodInfoPtr_ToIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, 100663411);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0002532C File Offset: 0x0002352C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131502, XrefRangeEnd = 131508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CodePointIndexer(Il2CppStructArray<int> starts, Il2CppStructArray<int> ends, int defaultIndex, int defaultCP)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(starts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ends);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultCP;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePointIndexer.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000253A8 File Offset: 0x000235A8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 131509, RefRangeEnd = 131524, XrefRangeStart = 131508, XrefRangeEnd = 131509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ToIndex(int cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePointIndexer.NativeMethodInfoPtr_ToIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000023B0 File Offset: 0x000005B0
		public CodePointIndexer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000253F4 File Offset: 0x000235F4
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000023B9 File Offset: 0x000005B9
		public unsafe Il2CppStructArray<CodePointIndexer.TableRange> ranges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_ranges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CodePointIndexer.TableRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_ranges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00025424 File Offset: 0x00023624
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000023D8 File Offset: 0x000005D8
		public unsafe int TotalCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_TotalCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_TotalCount)) = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0002544C File Offset: 0x0002364C
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000023F3 File Offset: 0x000005F3
		public unsafe int defaultIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_defaultIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_defaultIndex)) = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00025474 File Offset: 0x00023674
		// (set) Token: 0x060000AF RID: 175 RVA: 0x0000240E File Offset: 0x0000060E
		public unsafe int defaultCP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_defaultCP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePointIndexer.NativeFieldInfoPtr_defaultCP)) = value;
			}
		}

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_ranges;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_TotalCount;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_defaultIndex;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_defaultCP;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_ToIndex_Public_Int32_Int32_0;

		// Token: 0x0200053B RID: 1339
		[Serializable]
		[StructLayout(2)]
		public struct TableRange
		{
			// Token: 0x06004F16 RID: 20246 RVA: 0x001680F4 File Offset: 0x001662F4
			// Note: this type is marked as 'beforefieldinit'.
			static TableRange()
			{
				Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CodePointIndexer>.NativeClassPtr, "TableRange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr);
				CodePointIndexer.TableRange.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr, "Start");
				CodePointIndexer.TableRange.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr, "End");
				CodePointIndexer.TableRange.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr, "Count");
				CodePointIndexer.TableRange.NativeFieldInfoPtr_IndexStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr, "IndexStart");
				CodePointIndexer.TableRange.NativeFieldInfoPtr_IndexEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr, "IndexEnd");
				CodePointIndexer.TableRange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr, 100663412);
			}

			// Token: 0x06004F17 RID: 20247 RVA: 0x00168198 File Offset: 0x00166398
			[CallerCount(0)]
			public unsafe TableRange(int start, int end, int indexStart)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexStart;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePointIndexer.TableRange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F18 RID: 20248 RVA: 0x0001D9E0 File Offset: 0x0001BBE0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CodePointIndexer.TableRange>.NativeClassPtr, ref this));
			}

			// Token: 0x04003FD5 RID: 16341
			private static readonly IntPtr NativeFieldInfoPtr_Start;

			// Token: 0x04003FD6 RID: 16342
			private static readonly IntPtr NativeFieldInfoPtr_End;

			// Token: 0x04003FD7 RID: 16343
			private static readonly IntPtr NativeFieldInfoPtr_Count;

			// Token: 0x04003FD8 RID: 16344
			private static readonly IntPtr NativeFieldInfoPtr_IndexStart;

			// Token: 0x04003FD9 RID: 16345
			private static readonly IntPtr NativeFieldInfoPtr_IndexEnd;

			// Token: 0x04003FDA RID: 16346
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

			// Token: 0x04003FDB RID: 16347
			[FieldOffset(0)]
			public readonly int Start;

			// Token: 0x04003FDC RID: 16348
			[FieldOffset(4)]
			public readonly int End;

			// Token: 0x04003FDD RID: 16349
			[FieldOffset(8)]
			public readonly int Count;

			// Token: 0x04003FDE RID: 16350
			[FieldOffset(12)]
			public readonly int IndexStart;

			// Token: 0x04003FDF RID: 16351
			[FieldOffset(16)]
			public readonly int IndexEnd;
		}
	}
}
