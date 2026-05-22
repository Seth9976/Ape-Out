using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001A6 RID: 422
	public class Stairs : MonoBehaviour
	{
		// Token: 0x0600306D RID: 12397 RVA: 0x000B99E4 File Offset: 0x000B7BE4
		// Note: this type is marked as 'beforefieldinit'.
		static Stairs()
		{
			Il2CppClassPointerStore<Stairs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Stairs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stairs>.NativeClassPtr);
			Stairs.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stairs>.NativeClassPtr, "up");
			Stairs.NativeFieldInfoPtr_startFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stairs>.NativeClassPtr, "startFlag");
			Stairs.NativeFieldInfoPtr_teleDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stairs>.NativeClassPtr, "teleDist");
			Stairs.NativeFieldInfoPtr_nextBest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stairs>.NativeClassPtr, "nextBest");
			Stairs.NativeFieldInfoPtr_linkedStair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stairs>.NativeClassPtr, "linkedStair");
			Stairs.NativeFieldInfoPtr_manualTelespot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stairs>.NativeClassPtr, "manualTelespot");
			Stairs.NativeFieldInfoPtr_sendMessageToThis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stairs>.NativeClassPtr, "sendMessageToThis");
			Stairs.NativeFieldInfoPtr_dontAddToStairList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stairs>.NativeClassPtr, "dontAddToStairList");
			Stairs.NativeFieldInfoPtr_dontIncrementFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stairs>.NativeClassPtr, "dontIncrementFloor");
			Stairs.NativeFieldInfoPtr_teleported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stairs>.NativeClassPtr, "teleported");
			Stairs.NativeFieldInfoPtr_introOffsetAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stairs>.NativeClassPtr, "introOffsetAdd");
			Stairs.NativeFieldInfoPtr_introOffsetMinus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stairs>.NativeClassPtr, "introOffsetMinus");
			Stairs.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stairs>.NativeClassPtr, 100667086);
			Stairs.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stairs>.NativeClassPtr, 100667087);
			Stairs.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stairs>.NativeClassPtr, 100667088);
			Stairs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stairs>.NativeClassPtr, 100667089);
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x000B9B54 File Offset: 0x000B7D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84370, XrefRangeEnd = 84375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stairs.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x000B9B88 File Offset: 0x000B7D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84375, XrefRangeEnd = 84420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stairs.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x000B9BBC File Offset: 0x000B7DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84420, XrefRangeEnd = 84538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stairs.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x000B9C00 File Offset: 0x000B7E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stairs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stairs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stairs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x00021508 File Offset: 0x0001F708
		public Stairs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06003073 RID: 12403 RVA: 0x000B9C3C File Offset: 0x000B7E3C
		// (set) Token: 0x06003074 RID: 12404 RVA: 0x00021511 File Offset: 0x0001F711
		public unsafe bool up
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_up);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_up)) = value;
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06003075 RID: 12405 RVA: 0x000B9C64 File Offset: 0x000B7E64
		// (set) Token: 0x06003076 RID: 12406 RVA: 0x0002152C File Offset: 0x0001F72C
		public unsafe bool startFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_startFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_startFlag)) = value;
			}
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x000B9C8C File Offset: 0x000B7E8C
		// (set) Token: 0x06003078 RID: 12408 RVA: 0x00021547 File Offset: 0x0001F747
		public unsafe float teleDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_teleDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_teleDist)) = value;
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06003079 RID: 12409 RVA: 0x000B9CB4 File Offset: 0x000B7EB4
		// (set) Token: 0x0600307A RID: 12410 RVA: 0x00021562 File Offset: 0x0001F762
		public unsafe float nextBest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_nextBest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_nextBest)) = value;
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x0600307B RID: 12411 RVA: 0x000B9CDC File Offset: 0x000B7EDC
		// (set) Token: 0x0600307C RID: 12412 RVA: 0x0002157D File Offset: 0x0001F77D
		public unsafe GameObject linkedStair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_linkedStair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_linkedStair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x0600307D RID: 12413 RVA: 0x000B9D0C File Offset: 0x000B7F0C
		// (set) Token: 0x0600307E RID: 12414 RVA: 0x0002159C File Offset: 0x0001F79C
		public unsafe Vector2 manualTelespot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_manualTelespot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_manualTelespot)) = value;
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x0600307F RID: 12415 RVA: 0x000B9D34 File Offset: 0x000B7F34
		// (set) Token: 0x06003080 RID: 12416 RVA: 0x000215B7 File Offset: 0x0001F7B7
		public unsafe GameObject sendMessageToThis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_sendMessageToThis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_sendMessageToThis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06003081 RID: 12417 RVA: 0x000B9D64 File Offset: 0x000B7F64
		// (set) Token: 0x06003082 RID: 12418 RVA: 0x000215D6 File Offset: 0x0001F7D6
		public unsafe bool dontAddToStairList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_dontAddToStairList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_dontAddToStairList)) = value;
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06003083 RID: 12419 RVA: 0x000B9D8C File Offset: 0x000B7F8C
		// (set) Token: 0x06003084 RID: 12420 RVA: 0x000215F1 File Offset: 0x0001F7F1
		public unsafe bool dontIncrementFloor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_dontIncrementFloor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_dontIncrementFloor)) = value;
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06003085 RID: 12421 RVA: 0x000B9DB4 File Offset: 0x000B7FB4
		// (set) Token: 0x06003086 RID: 12422 RVA: 0x0002160C File Offset: 0x0001F80C
		public unsafe bool teleported
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_teleported);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_teleported)) = value;
			}
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x06003087 RID: 12423 RVA: 0x000B9DDC File Offset: 0x000B7FDC
		// (set) Token: 0x06003088 RID: 12424 RVA: 0x00021627 File Offset: 0x0001F827
		public unsafe bool introOffsetAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_introOffsetAdd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_introOffsetAdd)) = value;
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06003089 RID: 12425 RVA: 0x000B9E04 File Offset: 0x000B8004
		// (set) Token: 0x0600308A RID: 12426 RVA: 0x00021642 File Offset: 0x0001F842
		public unsafe bool introOffsetMinus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_introOffsetMinus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stairs.NativeFieldInfoPtr_introOffsetMinus)) = value;
			}
		}

		// Token: 0x04001C71 RID: 7281
		private static readonly IntPtr NativeFieldInfoPtr_up;

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeFieldInfoPtr_startFlag;

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeFieldInfoPtr_teleDist;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeFieldInfoPtr_nextBest;

		// Token: 0x04001C75 RID: 7285
		private static readonly IntPtr NativeFieldInfoPtr_linkedStair;

		// Token: 0x04001C76 RID: 7286
		private static readonly IntPtr NativeFieldInfoPtr_manualTelespot;

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeFieldInfoPtr_sendMessageToThis;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeFieldInfoPtr_dontAddToStairList;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeFieldInfoPtr_dontIncrementFloor;

		// Token: 0x04001C7A RID: 7290
		private static readonly IntPtr NativeFieldInfoPtr_teleported;

		// Token: 0x04001C7B RID: 7291
		private static readonly IntPtr NativeFieldInfoPtr_introOffsetAdd;

		// Token: 0x04001C7C RID: 7292
		private static readonly IntPtr NativeFieldInfoPtr_introOffsetMinus;

		// Token: 0x04001C7D RID: 7293
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001C7E RID: 7294
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001C7F RID: 7295
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

		// Token: 0x04001C80 RID: 7296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
