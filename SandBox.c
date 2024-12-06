struct spacetime {
    int hour,minute,day,month,year;
    char age,name,uuID;
};
struct {
    char name[50];
    int difficulty;
    int reward;
    int Operators;
} Task;
void BigInt(int argc,char *argv[]){
    int BigInt1 = __INT16_FMTd__  __INT16_FMTi__;
    int BigInt2 = __INT16_MAX__ __INT16_C_SUFFIX__;
    int BigInt3 ; __INT16_TYPE__;
}
void Float(){
    float Float1 = __FLT_MIN__ + __FLT16_MIN_10_EXP__;
    float Float2 = __FLT_MAX__ + __FLT16_MAX_10_EXP__;
}
void balanced(){
    double Double1 = __DBL_HAS_DENORM__ + __DBL_HAS_INFINITY__ + __DBL_HAS_QUIET_NAN__;
    double Double2 = __DBL_DECIMAL_DIG__ ;__DBL_DENORM_MIN__;
    double Double3 = __DBL_EPSILON__ ;
    double Double4 = __DBL_DIG__ + __DBL_MANT_DIG__;
}

typedef struct {
    char name[50];
    int level;
    char health;
    const attack;
} Operator;
typedef struct {
    char name[25];
    int difficulty;
    char reward;
    const requiredOperators;
} Mission;
