using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Collections
{
	// Token: 0x020001D7 RID: 471
	public class PriorityQueue : Object
	{
		// Token: 0x0600177C RID: 6012 RVA: 0x00069C98 File Offset: 0x00067E98
		// Note: this type is marked as 'beforefieldinit'.
		static PriorityQueue()
		{
			Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections", "PriorityQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr);
			PriorityQueue.NativeFieldInfoPtr_LevelMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, "LevelMaxValue");
			PriorityQueue.NativeFieldInfoPtr_Probability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, "Probability");
			PriorityQueue.NativeFieldInfoPtr_currentLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, "currentLevel");
			PriorityQueue.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, "header");
			PriorityQueue.NativeFieldInfoPtr_rand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, "rand");
			PriorityQueue.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, "count");
			PriorityQueue.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, "version");
			PriorityQueue.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, "comparer");
			PriorityQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666669);
			PriorityQueue.NativeMethodInfoPtr__ctor_Public_Void_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666670);
			PriorityQueue.NativeMethodInfoPtr_Enqueue_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666671);
			PriorityQueue.NativeMethodInfoPtr_Dequeue_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666672);
			PriorityQueue.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666673);
			PriorityQueue.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666674);
			PriorityQueue.NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666675);
			PriorityQueue.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666676);
			PriorityQueue.NativeMethodInfoPtr_Synchronized_Public_Static_PriorityQueue_PriorityQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666677);
			PriorityQueue.NativeMethodInfoPtr_NextLevel_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666678);
			PriorityQueue.NativeMethodInfoPtr_AssertValid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666679);
			PriorityQueue.NativeMethodInfoPtr_Test_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666680);
			PriorityQueue.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666681);
			PriorityQueue.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666682);
			PriorityQueue.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666683);
			PriorityQueue.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666684);
			PriorityQueue.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, 100666685);
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00069EBC File Offset: 0x000680BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 18858, RefRangeEnd = 18863, XrefRangeStart = 18847, XrefRangeEnd = 18858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PriorityQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00069EF8 File Offset: 0x000680F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18863, XrefRangeEnd = 18875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PriorityQueue(IComparer comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.NativeMethodInfoPtr__ctor_Public_Void_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00069F44 File Offset: 0x00068144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18875, XrefRangeEnd = 18898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Enqueue(Object element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.NativeMethodInfoPtr_Enqueue_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00069F94 File Offset: 0x00068194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18898, XrefRangeEnd = 18901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Dequeue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.NativeMethodInfoPtr_Dequeue_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00069FE0 File Offset: 0x000681E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18901, XrefRangeEnd = 18918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Remove(Object element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x0006A030 File Offset: 0x00068230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18918, XrefRangeEnd = 18927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(Object element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x0006A088 File Offset: 0x00068288
		[CallerCount(0)]
		public unsafe virtual Object Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x0006A0D4 File Offset: 0x000682D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18927, XrefRangeEnd = 18931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x0006A110 File Offset: 0x00068310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18931, XrefRangeEnd = 18935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PriorityQueue Synchronized(PriorityQueue queue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(queue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.NativeMethodInfoPtr_Synchronized_Public_Static_PriorityQueue_PriorityQueue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PriorityQueue>(intPtr3) : null;
			}
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x0006A154 File Offset: 0x00068354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 18936, RefRangeEnd = 18938, XrefRangeStart = 18935, XrefRangeEnd = 18936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int NextLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.NativeMethodInfoPtr_NextLevel_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0006A190 File Offset: 0x00068390
		[CallerCount(0)]
		public unsafe void AssertValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.NativeMethodInfoPtr_AssertValid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x0006A1C4 File Offset: 0x000683C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18938, XrefRangeEnd = 18950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Test()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.NativeMethodInfoPtr_Test_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x0006A1EC File Offset: 0x000683EC
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x0006A234 File Offset: 0x00068434
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0006A27C File Offset: 0x0006847C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18950, XrefRangeEnd = 18965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x0006A2D8 File Offset: 0x000684D8
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x0006A324 File Offset: 0x00068524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18965, XrefRangeEnd = 18968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x000096A4 File Offset: 0x000078A4
		public PriorityQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x0006A370 File Offset: 0x00068570
		// (set) Token: 0x06001790 RID: 6032 RVA: 0x000096AD File Offset: 0x000078AD
		public unsafe static int LevelMaxValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PriorityQueue.NativeFieldInfoPtr_LevelMaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PriorityQueue.NativeFieldInfoPtr_LevelMaxValue, (void*)(&value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x0006A38C File Offset: 0x0006858C
		// (set) Token: 0x06001792 RID: 6034 RVA: 0x000096BB File Offset: 0x000078BB
		public unsafe static double Probability
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(PriorityQueue.NativeFieldInfoPtr_Probability, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PriorityQueue.NativeFieldInfoPtr_Probability, (void*)(&value));
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x0006A3A8 File Offset: 0x000685A8
		// (set) Token: 0x06001794 RID: 6036 RVA: 0x000096C9 File Offset: 0x000078C9
		public unsafe int currentLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.NativeFieldInfoPtr_currentLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.NativeFieldInfoPtr_currentLevel)) = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x0006A3D0 File Offset: 0x000685D0
		// (set) Token: 0x06001796 RID: 6038 RVA: 0x000096E4 File Offset: 0x000078E4
		public unsafe PriorityQueue.Node header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.NativeFieldInfoPtr_header);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PriorityQueue.Node>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.NativeFieldInfoPtr_header), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x0006A400 File Offset: 0x00068600
		// (set) Token: 0x06001798 RID: 6040 RVA: 0x00009703 File Offset: 0x00007903
		public unsafe Random rand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.NativeFieldInfoPtr_rand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.NativeFieldInfoPtr_rand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x0006A430 File Offset: 0x00068630
		// (set) Token: 0x0600179A RID: 6042 RVA: 0x00009722 File Offset: 0x00007922
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x0006A458 File Offset: 0x00068658
		// (set) Token: 0x0600179C RID: 6044 RVA: 0x0000973D File Offset: 0x0000793D
		public unsafe long version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x0006A480 File Offset: 0x00068680
		// (set) Token: 0x0600179E RID: 6046 RVA: 0x00009758 File Offset: 0x00007958
		public unsafe IComparer comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018E3 RID: 6371
		private static readonly IntPtr NativeFieldInfoPtr_LevelMaxValue;

		// Token: 0x040018E4 RID: 6372
		private static readonly IntPtr NativeFieldInfoPtr_Probability;

		// Token: 0x040018E5 RID: 6373
		private static readonly IntPtr NativeFieldInfoPtr_currentLevel;

		// Token: 0x040018E6 RID: 6374
		private static readonly IntPtr NativeFieldInfoPtr_header;

		// Token: 0x040018E7 RID: 6375
		private static readonly IntPtr NativeFieldInfoPtr_rand;

		// Token: 0x040018E8 RID: 6376
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040018E9 RID: 6377
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040018EA RID: 6378
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x040018EB RID: 6379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_0;

		// Token: 0x040018ED RID: 6381
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Virtual_New_Void_Object_0;

		// Token: 0x040018EE RID: 6382
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_Virtual_New_Object_0;

		// Token: 0x040018EF RID: 6383
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0;

		// Token: 0x040018F0 RID: 6384
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x040018F1 RID: 6385
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_New_Object_0;

		// Token: 0x040018F2 RID: 6386
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x040018F3 RID: 6387
		private static readonly IntPtr NativeMethodInfoPtr_Synchronized_Public_Static_PriorityQueue_PriorityQueue_0;

		// Token: 0x040018F4 RID: 6388
		private static readonly IntPtr NativeMethodInfoPtr_NextLevel_Private_Int32_0;

		// Token: 0x040018F5 RID: 6389
		private static readonly IntPtr NativeMethodInfoPtr_AssertValid_Private_Void_0;

		// Token: 0x040018F6 RID: 6390
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Static_Void_0;

		// Token: 0x040018F7 RID: 6391
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040018F8 RID: 6392
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x040018F9 RID: 6393
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x040018FA RID: 6394
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

		// Token: 0x040018FB RID: 6395
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x0200025C RID: 604
		public class SynchronizedPriorityQueue : PriorityQueue
		{
			// Token: 0x06002104 RID: 8452 RVA: 0x00090000 File Offset: 0x0008E200
			// Note: this type is marked as 'beforefieldinit'.
			static SynchronizedPriorityQueue()
			{
				Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, "SynchronizedPriorityQueue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr);
				PriorityQueue.SynchronizedPriorityQueue.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr, "queue");
				PriorityQueue.SynchronizedPriorityQueue.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr, "root");
				PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr__ctor_Public_Void_PriorityQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr, 100666686);
				PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_Enqueue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr, 100666687);
				PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_Dequeue_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr, 100666688);
				PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr, 100666689);
				PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr, 100666690);
				PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr, 100666691);
				PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_Peek_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr, 100666692);
				PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr, 100666693);
				PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr, 100666694);
				PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr, 100666695);
				PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr, 100666696);
				PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr, 100666697);
			}

			// Token: 0x06002105 RID: 8453 RVA: 0x00090144 File Offset: 0x0008E344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18780, XrefRangeEnd = 18781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SynchronizedPriorityQueue(PriorityQueue queue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PriorityQueue.SynchronizedPriorityQueue>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(queue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr__ctor_Public_Void_PriorityQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002106 RID: 8454 RVA: 0x00090190 File Offset: 0x0008E390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18781, XrefRangeEnd = 18784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Enqueue(Object element)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_Enqueue_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002107 RID: 8455 RVA: 0x000901E0 File Offset: 0x0008E3E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18784, XrefRangeEnd = 18787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Dequeue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_Dequeue_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06002108 RID: 8456 RVA: 0x0009022C File Offset: 0x0008E42C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18787, XrefRangeEnd = 18790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Remove(Object element)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002109 RID: 8457 RVA: 0x0009027C File Offset: 0x0008E47C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18790, XrefRangeEnd = 18793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600210A RID: 8458 RVA: 0x000902B8 File Offset: 0x0008E4B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18793, XrefRangeEnd = 18796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Contains(Object element)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600210B RID: 8459 RVA: 0x00090310 File Offset: 0x0008E510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18796, XrefRangeEnd = 18799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Peek()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_Peek_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x0600210C RID: 8460 RVA: 0x0009035C File Offset: 0x0008E55C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18799, XrefRangeEnd = 18802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void CopyTo(Array array, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000695 RID: 1685
			// (get) Token: 0x0600210D RID: 8461 RVA: 0x000903B8 File Offset: 0x0008E5B8
			public unsafe override int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18802, XrefRangeEnd = 18805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000696 RID: 1686
			// (get) Token: 0x0600210E RID: 8462 RVA: 0x00090400 File Offset: 0x0008E600
			public unsafe override bool IsSynchronized
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000697 RID: 1687
			// (get) Token: 0x0600210F RID: 8463 RVA: 0x00090448 File Offset: 0x0008E648
			public unsafe override Object SyncRoot
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002110 RID: 8464 RVA: 0x00090494 File Offset: 0x0008E694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18805, XrefRangeEnd = 18808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PriorityQueue.SynchronizedPriorityQueue.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002111 RID: 8465 RVA: 0x0000C3BD File Offset: 0x0000A5BD
			public SynchronizedPriorityQueue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000693 RID: 1683
			// (get) Token: 0x06002112 RID: 8466 RVA: 0x000904E0 File Offset: 0x0008E6E0
			// (set) Token: 0x06002113 RID: 8467 RVA: 0x0000C3C6 File Offset: 0x0000A5C6
			public unsafe PriorityQueue queue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.SynchronizedPriorityQueue.NativeFieldInfoPtr_queue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PriorityQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.SynchronizedPriorityQueue.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000694 RID: 1684
			// (get) Token: 0x06002114 RID: 8468 RVA: 0x00090510 File Offset: 0x0008E710
			// (set) Token: 0x06002115 RID: 8469 RVA: 0x0000C3E5 File Offset: 0x0000A5E5
			public unsafe Object root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.SynchronizedPriorityQueue.NativeFieldInfoPtr_root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.SynchronizedPriorityQueue.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020AE RID: 8366
			private static readonly IntPtr NativeFieldInfoPtr_queue;

			// Token: 0x040020AF RID: 8367
			private static readonly IntPtr NativeFieldInfoPtr_root;

			// Token: 0x040020B0 RID: 8368
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PriorityQueue_0;

			// Token: 0x040020B1 RID: 8369
			private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Virtual_Void_Object_0;

			// Token: 0x040020B2 RID: 8370
			private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_Virtual_Object_0;

			// Token: 0x040020B3 RID: 8371
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0;

			// Token: 0x040020B4 RID: 8372
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

			// Token: 0x040020B5 RID: 8373
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0;

			// Token: 0x040020B6 RID: 8374
			private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Object_0;

			// Token: 0x040020B7 RID: 8375
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0;

			// Token: 0x040020B8 RID: 8376
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

			// Token: 0x040020B9 RID: 8377
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0;

			// Token: 0x040020BA RID: 8378
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0;

			// Token: 0x040020BB RID: 8379
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0;
		}

		// Token: 0x0200025D RID: 605
		public class DefaultComparer : Object
		{
			// Token: 0x06002116 RID: 8470 RVA: 0x00090540 File Offset: 0x0008E740
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultComparer()
			{
				Il2CppClassPointerStore<PriorityQueue.DefaultComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, "DefaultComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PriorityQueue.DefaultComparer>.NativeClassPtr);
				PriorityQueue.DefaultComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.DefaultComparer>.NativeClassPtr, 100666698);
				PriorityQueue.DefaultComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.DefaultComparer>.NativeClassPtr, 100666699);
			}

			// Token: 0x06002117 RID: 8471 RVA: 0x00090594 File Offset: 0x0008E794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18808, XrefRangeEnd = 18824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.DefaultComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002118 RID: 8472 RVA: 0x000905F4 File Offset: 0x0008E7F4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PriorityQueue.DefaultComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.DefaultComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002119 RID: 8473 RVA: 0x0000C404 File Offset: 0x0000A604
			public DefaultComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040020BC RID: 8380
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;

			// Token: 0x040020BD RID: 8381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200025E RID: 606
		public class Node : Object
		{
			// Token: 0x0600211A RID: 8474 RVA: 0x00090630 File Offset: 0x0008E830
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<PriorityQueue.Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, "Node");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PriorityQueue.Node>.NativeClassPtr);
				PriorityQueue.Node.NativeFieldInfoPtr_forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue.Node>.NativeClassPtr, "forward");
				PriorityQueue.Node.NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue.Node>.NativeClassPtr, "element");
				PriorityQueue.Node.NativeMethodInfoPtr__ctor_Public_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.Node>.NativeClassPtr, 100666700);
				PriorityQueue.Node.NativeMethodInfoPtr_get_Item_Public_get_Node_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.Node>.NativeClassPtr, 100666701);
				PriorityQueue.Node.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.Node>.NativeClassPtr, 100666702);
				PriorityQueue.Node.NativeMethodInfoPtr_get_Element_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.Node>.NativeClassPtr, 100666703);
			}

			// Token: 0x0600211B RID: 8475 RVA: 0x000906D4 File Offset: 0x0008E8D4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 18827, RefRangeEnd = 18831, XrefRangeStart = 18824, XrefRangeEnd = 18827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Node(Object element, int level)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PriorityQueue.Node>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.Node.NativeMethodInfoPtr__ctor_Public_Void_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700069A RID: 1690
			public unsafe PriorityQueue.Node this[int index]
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 18831, RefRangeEnd = 18841, XrefRangeStart = 18831, XrefRangeEnd = 18831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.Node.NativeMethodInfoPtr_get_Item_Public_get_Node_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PriorityQueue.Node>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18841, XrefRangeEnd = 18846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.Node.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700069B RID: 1691
			// (get) Token: 0x0600211E RID: 8478 RVA: 0x000907CC File Offset: 0x0008E9CC
			public unsafe Object Element
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.Node.NativeMethodInfoPtr_get_Element_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600211F RID: 8479 RVA: 0x0000C40D File Offset: 0x0000A60D
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000698 RID: 1688
			// (get) Token: 0x06002120 RID: 8480 RVA: 0x0009080C File Offset: 0x0008EA0C
			// (set) Token: 0x06002121 RID: 8481 RVA: 0x0000C416 File Offset: 0x0000A616
			public unsafe Il2CppReferenceArray<PriorityQueue.Node> forward
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.Node.NativeFieldInfoPtr_forward);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PriorityQueue.Node>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.Node.NativeFieldInfoPtr_forward), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x06002122 RID: 8482 RVA: 0x0009083C File Offset: 0x0008EA3C
			// (set) Token: 0x06002123 RID: 8483 RVA: 0x0000C435 File Offset: 0x0000A635
			public unsafe Object element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.Node.NativeFieldInfoPtr_element);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.Node.NativeFieldInfoPtr_element), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020BE RID: 8382
			private static readonly IntPtr NativeFieldInfoPtr_forward;

			// Token: 0x040020BF RID: 8383
			private static readonly IntPtr NativeFieldInfoPtr_element;

			// Token: 0x040020C0 RID: 8384
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Int32_0;

			// Token: 0x040020C1 RID: 8385
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Node_Int32_0;

			// Token: 0x040020C2 RID: 8386
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Node_0;

			// Token: 0x040020C3 RID: 8387
			private static readonly IntPtr NativeMethodInfoPtr_get_Element_Public_get_Object_0;
		}

		// Token: 0x0200025F RID: 607
		public class PriorityQueueEnumerator : Object
		{
			// Token: 0x06002124 RID: 8484 RVA: 0x0009086C File Offset: 0x0008EA6C
			// Note: this type is marked as 'beforefieldinit'.
			static PriorityQueueEnumerator()
			{
				Il2CppClassPointerStore<PriorityQueue.PriorityQueueEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PriorityQueue>.NativeClassPtr, "PriorityQueueEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PriorityQueue.PriorityQueueEnumerator>.NativeClassPtr);
				PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue.PriorityQueueEnumerator>.NativeClassPtr, "owner");
				PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue.PriorityQueueEnumerator>.NativeClassPtr, "head");
				PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_currentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue.PriorityQueueEnumerator>.NativeClassPtr, "currentNode");
				PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_moveResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue.PriorityQueueEnumerator>.NativeClassPtr, "moveResult");
				PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue.PriorityQueueEnumerator>.NativeClassPtr, "version");
				PriorityQueue.PriorityQueueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_PriorityQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.PriorityQueueEnumerator>.NativeClassPtr, 100666704);
				PriorityQueue.PriorityQueueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.PriorityQueueEnumerator>.NativeClassPtr, 100666705);
				PriorityQueue.PriorityQueueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.PriorityQueueEnumerator>.NativeClassPtr, 100666706);
				PriorityQueue.PriorityQueueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue.PriorityQueueEnumerator>.NativeClassPtr, 100666707);
			}

			// Token: 0x06002125 RID: 8485 RVA: 0x0009094C File Offset: 0x0008EB4C
			[CallerCount(0)]
			public unsafe PriorityQueueEnumerator(PriorityQueue owner)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PriorityQueue.PriorityQueueEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.PriorityQueueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_PriorityQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002126 RID: 8486 RVA: 0x00090998 File Offset: 0x0008EB98
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.PriorityQueueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006A1 RID: 1697
			// (get) Token: 0x06002127 RID: 8487 RVA: 0x000909CC File Offset: 0x0008EBCC
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.PriorityQueueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002128 RID: 8488 RVA: 0x00090A0C File Offset: 0x0008EC0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18846, XrefRangeEnd = 18847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue.PriorityQueueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002129 RID: 8489 RVA: 0x0000C454 File Offset: 0x0000A654
			public PriorityQueueEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700069C RID: 1692
			// (get) Token: 0x0600212A RID: 8490 RVA: 0x00090A48 File Offset: 0x0008EC48
			// (set) Token: 0x0600212B RID: 8491 RVA: 0x0000C45D File Offset: 0x0000A65D
			public unsafe PriorityQueue owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PriorityQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x0600212C RID: 8492 RVA: 0x00090A78 File Offset: 0x0008EC78
			// (set) Token: 0x0600212D RID: 8493 RVA: 0x0000C47C File Offset: 0x0000A67C
			public unsafe PriorityQueue.Node head
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_head);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PriorityQueue.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069E RID: 1694
			// (get) Token: 0x0600212E RID: 8494 RVA: 0x00090AA8 File Offset: 0x0008ECA8
			// (set) Token: 0x0600212F RID: 8495 RVA: 0x0000C49B File Offset: 0x0000A69B
			public unsafe PriorityQueue.Node currentNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_currentNode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PriorityQueue.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_currentNode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069F RID: 1695
			// (get) Token: 0x06002130 RID: 8496 RVA: 0x00090AD8 File Offset: 0x0008ECD8
			// (set) Token: 0x06002131 RID: 8497 RVA: 0x0000C4BA File Offset: 0x0000A6BA
			public unsafe bool moveResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_moveResult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_moveResult)) = value;
				}
			}

			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x06002132 RID: 8498 RVA: 0x00090B00 File Offset: 0x0008ED00
			// (set) Token: 0x06002133 RID: 8499 RVA: 0x0000C4D5 File Offset: 0x0000A6D5
			public unsafe long version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue.PriorityQueueEnumerator.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x040020C4 RID: 8388
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x040020C5 RID: 8389
			private static readonly IntPtr NativeFieldInfoPtr_head;

			// Token: 0x040020C6 RID: 8390
			private static readonly IntPtr NativeFieldInfoPtr_currentNode;

			// Token: 0x040020C7 RID: 8391
			private static readonly IntPtr NativeFieldInfoPtr_moveResult;

			// Token: 0x040020C8 RID: 8392
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x040020C9 RID: 8393
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PriorityQueue_0;

			// Token: 0x040020CA RID: 8394
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x040020CB RID: 8395
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040020CC RID: 8396
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
		}
	}
}
