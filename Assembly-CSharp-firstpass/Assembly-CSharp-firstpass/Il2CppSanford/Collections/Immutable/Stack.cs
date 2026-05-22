using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Collections.Immutable
{
	// Token: 0x020001E4 RID: 484
	public class Stack : Object
	{
		// Token: 0x0600189E RID: 6302 RVA: 0x0006E644 File Offset: 0x0006C844
		// Note: this type is marked as 'beforefieldinit'.
		static Stack()
		{
			Il2CppClassPointerStore<Stack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Immutable", "Stack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stack>.NativeClassPtr);
			Stack.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack>.NativeClassPtr, "Empty");
			Stack.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack>.NativeClassPtr, "count");
			Stack.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack>.NativeClassPtr, "top");
			Stack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100666875);
			Stack.NativeMethodInfoPtr__ctor_Private_Void_Node_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100666876);
			Stack.NativeMethodInfoPtr_Push_Public_Stack_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100666877);
			Stack.NativeMethodInfoPtr_Pop_Public_Stack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100666878);
			Stack.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100666879);
			Stack.NativeMethodInfoPtr_get_Top_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100666880);
			Stack.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack>.NativeClassPtr, 100666881);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0006E73C File Offset: 0x0006C93C
		[CallerCount(0)]
		public unsafe Stack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0006E778 File Offset: 0x0006C978
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 19461, RefRangeEnd = 19470, XrefRangeStart = 19461, XrefRangeEnd = 19470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack(Stack.Node top, int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(top);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.NativeMethodInfoPtr__ctor_Private_Void_Node_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0006E7D4 File Offset: 0x0006C9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20154, XrefRangeEnd = 20160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack Push(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.NativeMethodInfoPtr_Push_Public_Stack_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr3) : null;
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0006E824 File Offset: 0x0006CA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20160, XrefRangeEnd = 20164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.NativeMethodInfoPtr_Pop_Public_Stack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr3) : null;
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x0006E864 File Offset: 0x0006CA64
		public unsafe int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x0006E8A0 File Offset: 0x0006CAA0
		public unsafe Object Top
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.NativeMethodInfoPtr_get_Top_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0006E8E0 File Offset: 0x0006CAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20164, XrefRangeEnd = 20167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00009CE8 File Offset: 0x00007EE8
		public Stack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x0006E920 File Offset: 0x0006CB20
		// (set) Token: 0x060018A8 RID: 6312 RVA: 0x00009CF1 File Offset: 0x00007EF1
		public unsafe static Stack Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Stack.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stack.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x0006E948 File Offset: 0x0006CB48
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x00009D03 File Offset: 0x00007F03
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x0006E970 File Offset: 0x0006CB70
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x00009D1E File Offset: 0x00007F1E
		public unsafe Stack.Node top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr_top);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack.Node>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.NativeFieldInfoPtr_top), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019B8 RID: 6584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Node_Int32_0;

		// Token: 0x040019B9 RID: 6585
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Stack_Object_0;

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Stack_0;

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeMethodInfoPtr_get_Top_Public_get_Object_0;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x02000264 RID: 612
		public class Node : Object
		{
			// Token: 0x06002169 RID: 8553 RVA: 0x0009170C File Offset: 0x0008F90C
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<Stack.Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stack>.NativeClassPtr, "Node");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stack.Node>.NativeClassPtr);
				Stack.Node.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack.Node>.NativeClassPtr, "next");
				Stack.Node.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack.Node>.NativeClassPtr, "value");
				Stack.Node.NativeMethodInfoPtr__ctor_Public_Void_Object_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.Node>.NativeClassPtr, 100666883);
				Stack.Node.NativeMethodInfoPtr_get_Next_Public_get_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.Node>.NativeClassPtr, 100666884);
				Stack.Node.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.Node>.NativeClassPtr, 100666885);
			}

			// Token: 0x0600216A RID: 8554 RVA: 0x0009179C File Offset: 0x0008F99C
			[CallerCount(0)]
			public unsafe Node(Object value, Stack.Node next)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack.Node>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.Node.NativeMethodInfoPtr__ctor_Public_Void_Object_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006B7 RID: 1719
			// (get) Token: 0x0600216B RID: 8555 RVA: 0x000917FC File Offset: 0x0008F9FC
			public unsafe Stack.Node Next
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.Node.NativeMethodInfoPtr_get_Next_Public_get_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stack.Node>(intPtr3) : null;
				}
			}

			// Token: 0x170006B8 RID: 1720
			// (get) Token: 0x0600216C RID: 8556 RVA: 0x0009183C File Offset: 0x0008FA3C
			public unsafe Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.Node.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600216D RID: 8557 RVA: 0x0000C62B File Offset: 0x0000A82B
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006B5 RID: 1717
			// (get) Token: 0x0600216E RID: 8558 RVA: 0x0009187C File Offset: 0x0008FA7C
			// (set) Token: 0x0600216F RID: 8559 RVA: 0x0000C634 File Offset: 0x0000A834
			public unsafe Stack.Node next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.Node.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.Node.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B6 RID: 1718
			// (get) Token: 0x06002170 RID: 8560 RVA: 0x000918AC File Offset: 0x0008FAAC
			// (set) Token: 0x06002171 RID: 8561 RVA: 0x0000C653 File Offset: 0x0000A853
			public unsafe Object value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.Node.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.Node.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020EF RID: 8431
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x040020F0 RID: 8432
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040020F1 RID: 8433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Node_0;

			// Token: 0x040020F2 RID: 8434
			private static readonly IntPtr NativeMethodInfoPtr_get_Next_Public_get_Node_0;

			// Token: 0x040020F3 RID: 8435
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;
		}

		// Token: 0x02000265 RID: 613
		public class StackEnumerator : Object
		{
			// Token: 0x06002172 RID: 8562 RVA: 0x000918DC File Offset: 0x0008FADC
			// Note: this type is marked as 'beforefieldinit'.
			static StackEnumerator()
			{
				Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stack>.NativeClassPtr, "StackEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr);
				Stack.StackEnumerator.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, "owner");
				Stack.StackEnumerator.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, "index");
				Stack.StackEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, "current");
				Stack.StackEnumerator.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, "next");
				Stack.StackEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Stack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, 100666886);
				Stack.StackEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, 100666887);
				Stack.StackEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, 100666888);
				Stack.StackEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr, 100666889);
			}

			// Token: 0x06002173 RID: 8563 RVA: 0x000919A8 File Offset: 0x0008FBA8
			[CallerCount(0)]
			public unsafe StackEnumerator(Stack owner)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack.StackEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.StackEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Stack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002174 RID: 8564 RVA: 0x000919F4 File Offset: 0x0008FBF4
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.StackEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006BD RID: 1725
			// (get) Token: 0x06002175 RID: 8565 RVA: 0x00091A28 File Offset: 0x0008FC28
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.StackEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002176 RID: 8566 RVA: 0x00091A68 File Offset: 0x0008FC68
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack.StackEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002177 RID: 8567 RVA: 0x0000C672 File Offset: 0x0000A872
			public StackEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006B9 RID: 1721
			// (get) Token: 0x06002178 RID: 8568 RVA: 0x00091AA4 File Offset: 0x0008FCA4
			// (set) Token: 0x06002179 RID: 8569 RVA: 0x0000C67B File Offset: 0x0000A87B
			public unsafe Stack owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr_owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006BA RID: 1722
			// (get) Token: 0x0600217A RID: 8570 RVA: 0x00091AD4 File Offset: 0x0008FCD4
			// (set) Token: 0x0600217B RID: 8571 RVA: 0x0000C69A File Offset: 0x0000A89A
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170006BB RID: 1723
			// (get) Token: 0x0600217C RID: 8572 RVA: 0x00091AFC File Offset: 0x0008FCFC
			// (set) Token: 0x0600217D RID: 8573 RVA: 0x0000C6B5 File Offset: 0x0000A8B5
			public unsafe Stack.Node current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006BC RID: 1724
			// (get) Token: 0x0600217E RID: 8574 RVA: 0x00091B2C File Offset: 0x0008FD2C
			// (set) Token: 0x0600217F RID: 8575 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
			public unsafe Stack.Node next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack.StackEnumerator.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020F4 RID: 8436
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x040020F5 RID: 8437
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040020F6 RID: 8438
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x040020F7 RID: 8439
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x040020F8 RID: 8440
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stack_0;

			// Token: 0x040020F9 RID: 8441
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x040020FA RID: 8442
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040020FB RID: 8443
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
		}
	}
}
