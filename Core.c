char core1 = __ATOMIC_ACQ_REL;
char core2 = __ATOMIC_ACQUIRE;
char core3 = __ATOMIC_CONSUME;
char core4 = __ATOMIC_RELAXED;
char core5 = __ATOMIC_RELEASE;
char core6 = __ATOMIC_SEQ_CST;
#define _Atomic mixed_core
void mixed_core(){
     const _Atomic = core1 + core2 + core3 + core4 + core5 + core6;
     const _Atomic = (core1 + core2) / (core3 * core4 * core5);
int inner_core();{
     inline inner_core [(core1 + core2) * core3];
     inline inner_core [core4/core5/core6];
}
int outer_core();{
     outer_core ; extern ; (core3 / core4 / core5) ;
     outer_core ; extern ; (core1 + core6) / (core4 + core5) ;
}
}