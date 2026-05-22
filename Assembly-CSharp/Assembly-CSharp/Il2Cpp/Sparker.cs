using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001A1 RID: 417
	public class Sparker : MonoBehaviour
	{
		// Token: 0x06003031 RID: 12337 RVA: 0x000B9050 File Offset: 0x000B7250
		// Note: this type is marked as 'beforefieldinit'.
		static Sparker()
		{
			Il2CppClassPointerStore<Sparker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Sparker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sparker>.NativeClassPtr);
			Sparker.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sparker>.NativeClassPtr, "line");
			Sparker.NativeFieldInfoPtr_aud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sparker>.NativeClassPtr, "aud");
			Sparker.NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sparker>.NativeClassPtr, "dest");
			Sparker.NativeFieldInfoPtr_vertNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sparker>.NativeClassPtr, "vertNum");
			Sparker.NativeFieldInfoPtr_delaypt07 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sparker>.NativeClassPtr, "delaypt07");
			Sparker.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sparker>.NativeClassPtr, 100667066);
			Sparker.NativeMethodInfoPtr_Pop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sparker>.NativeClassPtr, 100667067);
			Sparker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sparker>.NativeClassPtr, 100667068);
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x000B9120 File Offset: 0x000B7320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84147, XrefRangeEnd = 84157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sparker.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x000B9154 File Offset: 0x000B7354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84160, RefRangeEnd = 84162, XrefRangeStart = 84157, XrefRangeEnd = 84160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sparker.NativeMethodInfoPtr_Pop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x000B9194 File Offset: 0x000B7394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84162, XrefRangeEnd = 84168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sparker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sparker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sparker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x000212D1 File Offset: 0x0001F4D1
		public Sparker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06003036 RID: 12342 RVA: 0x000B91D0 File Offset: 0x000B73D0
		// (set) Token: 0x06003037 RID: 12343 RVA: 0x000212DA File Offset: 0x0001F4DA
		public unsafe LineRenderer line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker.NativeFieldInfoPtr_line);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker.NativeFieldInfoPtr_line), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06003038 RID: 12344 RVA: 0x000B9200 File Offset: 0x000B7400
		// (set) Token: 0x06003039 RID: 12345 RVA: 0x000212F9 File Offset: 0x0001F4F9
		public unsafe AudioSource aud
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker.NativeFieldInfoPtr_aud);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker.NativeFieldInfoPtr_aud), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x0600303A RID: 12346 RVA: 0x000B9230 File Offset: 0x000B7430
		// (set) Token: 0x0600303B RID: 12347 RVA: 0x00021318 File Offset: 0x0001F518
		public unsafe Transform dest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker.NativeFieldInfoPtr_dest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker.NativeFieldInfoPtr_dest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x0600303C RID: 12348 RVA: 0x000B9260 File Offset: 0x000B7460
		// (set) Token: 0x0600303D RID: 12349 RVA: 0x00021337 File Offset: 0x0001F537
		public unsafe int vertNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker.NativeFieldInfoPtr_vertNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker.NativeFieldInfoPtr_vertNum)) = value;
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x0600303E RID: 12350 RVA: 0x000B9288 File Offset: 0x000B7488
		// (set) Token: 0x0600303F RID: 12351 RVA: 0x00021352 File Offset: 0x0001F552
		public unsafe WaitForSeconds delaypt07
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker.NativeFieldInfoPtr_delaypt07);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker.NativeFieldInfoPtr_delaypt07), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeFieldInfoPtr_aud;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeFieldInfoPtr_dest;

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeFieldInfoPtr_vertNum;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeFieldInfoPtr_delaypt07;

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_IEnumerator_0;

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000351 RID: 849
		[ObfuscatedName("Sparker+<Pop>d__6")]
		public sealed class _Pop_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x06005384 RID: 21380 RVA: 0x0012ED98 File Offset: 0x0012CF98
			// Note: this type is marked as 'beforefieldinit'.
			static _Pop_d__6()
			{
				Il2CppClassPointerStore<Sparker._Pop_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sparker>.NativeClassPtr, "<Pop>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sparker._Pop_d__6>.NativeClassPtr);
				Sparker._Pop_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sparker._Pop_d__6>.NativeClassPtr, "<>1__state");
				Sparker._Pop_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sparker._Pop_d__6>.NativeClassPtr, "<>2__current");
				Sparker._Pop_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sparker._Pop_d__6>.NativeClassPtr, "<>4__this");
				Sparker._Pop_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sparker._Pop_d__6>.NativeClassPtr, 100667069);
				Sparker._Pop_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sparker._Pop_d__6>.NativeClassPtr, 100667070);
				Sparker._Pop_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sparker._Pop_d__6>.NativeClassPtr, 100667071);
				Sparker._Pop_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sparker._Pop_d__6>.NativeClassPtr, 100667072);
				Sparker._Pop_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sparker._Pop_d__6>.NativeClassPtr, 100667073);
				Sparker._Pop_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sparker._Pop_d__6>.NativeClassPtr, 100667074);
			}

			// Token: 0x06005385 RID: 21381 RVA: 0x0012EE78 File Offset: 0x0012D078
			[CallerCount(0)]
			public unsafe _Pop_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sparker._Pop_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sparker._Pop_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005386 RID: 21382 RVA: 0x0012EEC0 File Offset: 0x0012D0C0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sparker._Pop_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005387 RID: 21383 RVA: 0x0012EEF4 File Offset: 0x0012D0F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84133, XrefRangeEnd = 84142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sparker._Pop_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E76 RID: 7798
			// (get) Token: 0x06005388 RID: 21384 RVA: 0x0012EF30 File Offset: 0x0012D130
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sparker._Pop_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005389 RID: 21385 RVA: 0x0012EF70 File Offset: 0x0012D170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84142, XrefRangeEnd = 84147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sparker._Pop_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E77 RID: 7799
			// (get) Token: 0x0600538A RID: 21386 RVA: 0x0012EFA4 File Offset: 0x0012D1A4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sparker._Pop_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600538B RID: 21387 RVA: 0x00030994 File Offset: 0x0002EB94
			public _Pop_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E73 RID: 7795
			// (get) Token: 0x0600538C RID: 21388 RVA: 0x0012EFE4 File Offset: 0x0012D1E4
			// (set) Token: 0x0600538D RID: 21389 RVA: 0x0003099D File Offset: 0x0002EB9D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker._Pop_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker._Pop_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E74 RID: 7796
			// (get) Token: 0x0600538E RID: 21390 RVA: 0x0012F00C File Offset: 0x0012D20C
			// (set) Token: 0x0600538F RID: 21391 RVA: 0x000309B8 File Offset: 0x0002EBB8
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker._Pop_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker._Pop_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E75 RID: 7797
			// (get) Token: 0x06005390 RID: 21392 RVA: 0x0012F03C File Offset: 0x0012D23C
			// (set) Token: 0x06005391 RID: 21393 RVA: 0x000309D7 File Offset: 0x0002EBD7
			public unsafe Sparker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker._Pop_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sparker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sparker._Pop_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003722 RID: 14114
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003723 RID: 14115
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003724 RID: 14116
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003725 RID: 14117
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003726 RID: 14118
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003727 RID: 14119
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003728 RID: 14120
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003729 RID: 14121
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400372A RID: 14122
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
